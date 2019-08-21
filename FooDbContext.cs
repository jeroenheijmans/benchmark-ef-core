using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace BenchmarkEfCore
{
    public class FooDbContext : DbContext
    {
        public DbSet<AggregateRoot> Roots { get; set; }
        public DbSet<RelatedEntity> RelatedItems { get; set; }

        public FooDbContext(DbContextOptions<FooDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var related = modelBuilder.Entity<RelatedEntity>().HasIndex(r => r.Code).IsUnique();
            var root = modelBuilder.Entity<AggregateRoot>();

            root.HasOne(r => r.RelatedEntity);

            root.OwnsOne(a => a.ChildOne, o =>
            {
                o.Property(x => x.OwnedValueObjects).HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<ValueObject>>(v)
                );
            });

            root.OwnsOne(a => a.ChildTwo1);
            root.OwnsOne(a => a.ChildTwo2);
            root.OwnsOne(a => a.ChildTwo3);
            root.OwnsOne(a => a.ChildTwo4);
        }
    }
}
