using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;

namespace BenchmarkEfCore
{
    public class Benchmark
    {
        private FooDbContext dbContext;

        [Params(100, 1000, 10000)]
        public int EntityCount { get; set; }

        public int QueryStart => EntityCount / 3;

        [GlobalSetup]
        public void GlobalSetup()
        {
            var dbName = Guid.NewGuid().ToString().Replace("-", "");
            var connectionString = $"Server=(localdb)\\mssqllocaldb;Database=benchmark{dbName};Trusted_Connection=True;";
            dbContext = new FooDbContextFactory(connectionString).CreateDbContext();
            dbContext.Database.Migrate();

            dbContext.Roots.AddRange(
                Enumerable.Range(1, EntityCount).Select(i => new AggregateRoot { Baz0 = i })
            );

            dbContext.SaveChanges();

            Console.WriteLine($"GlobalSetup finished creating database {dbName} with {dbContext.Roots.Count()} entities.");
        }

        [GlobalCleanup]
        public void GlobalCleanup()
        {
            dbContext.Database.EnsureDeleted();
            dbContext.Dispose();
        }

        [IterationSetup]
        public void IterationSetup()
        {
            dbContext.Database.ExecuteSqlCommand("UPDATE [Roots] SET Bar1 = 0");
        }

        [Benchmark]
        public void WithoutAnyUpdatesNoSaveChanges()
        {
            var entities = dbContext.Roots
                .AsNoTracking()
                .Where(r => r.Baz0 > QueryStart)
                .ToList();
        }

        [Benchmark]
        public void WithoutAnyUpdatesSuperfluousSaveChanges()
        {
            var entities = dbContext.Roots
                .AsNoTracking()
                .Where(r => r.Baz0 > QueryStart)
                .ToList();

            dbContext.SaveChanges();
        }

        [Benchmark]
        public void WithTracking()
        {
            var entities = dbContext.Roots
                .Where(r => r.Baz0 > QueryStart)
                .ToList();

            foreach (var entity in entities)
            {
                entity.Bar1 = true;
            }

            dbContext.SaveChanges();
        }

        [Benchmark]
        public void WithUnsafeSql()
        {
            var entities = dbContext.Roots
                .AsNoTracking()
                .Where(r => r.Baz0 > QueryStart)
                .ToList();

#pragma warning disable EF1000 // Possible SQL injection vulnerability.
            var ids = string.Join(",", entities.Select(e => $"'{e.Id}'").ToArray());

            dbContext.Database.ExecuteSqlCommand(
                "UPDATE [Roots] SET Bar1 = 1 WHERE Id IN (" + ids + ")"
            );
#pragma warning restore EF1000 // Possible SQL injection vulnerability.

            // No dbContext.SaveChanges() needed here.
        }
    }
}
