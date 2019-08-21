using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BenchmarkEfCore
{
    internal class FooDbContextFactory : IDesignTimeDbContextFactory<FooDbContext>
    {
        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=FooBar;Trusted_Connection=True;";
        private readonly DbContextOptionsBuilder<FooDbContext> builder;

        public FooDbContextFactory()
        {
            builder = new DbContextOptionsBuilder<FooDbContext>()
                .UseSqlServer(connectionString);
        }

        public FooDbContext CreateDbContext(string[] args = null)
            => new FooDbContext(builder.Options);
    }
}
