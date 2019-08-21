using System;
using Microsoft.EntityFrameworkCore;

namespace BenchmarkEfCore
{
    public class Program
    {
        static void Main(string[] args)
        {
            var factory = new FooDbContextFactory();

            using (var context = factory.CreateDbContext())
            {
                context.Database.Migrate();

                var item = context.RelatedItems.Add(new RelatedEntity());
                var root = context.Roots.Add(new AggregateRoot { RelatedEntity = item.Entity });

                context.SaveChanges();
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
