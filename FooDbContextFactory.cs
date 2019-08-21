using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BenchmarkEfCore
{
    internal class FooDbContextFactory : IDesignTimeDbContextFactory<FooDbContext>
    {
        private const string defaultConnectionString = "Server=(localdb)\\mssqllocaldb;Database=FooBar;Trusted_Connection=True;";
        private readonly DbContextOptionsBuilder<FooDbContext> optionsBuilder;

        public FooDbContextFactory()
            : this(defaultConnectionString)
        { }

        public FooDbContextFactory(string connectionString)
        {
            optionsBuilder = new DbContextOptionsBuilder<FooDbContext>()
               .UseSqlServer(connectionString);
        }

        public FooDbContext CreateDbContext(string[] args)
            => CreateDbContext();

        public FooDbContext CreateDbContext()
            => new FooDbContext(optionsBuilder.Options);
    }
}
