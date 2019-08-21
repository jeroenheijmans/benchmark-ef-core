using System;
using BenchmarkDotNet.Running;
using Microsoft.EntityFrameworkCore;

namespace BenchmarkEfCore
{
    public class Program
    {
        static void Main(string[] args)
        {
            // RunAsHelloWorld();
            BenchmarkRunner.Run<Benchmark>();

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }

        private static void RunAsHelloWorld()
        {
            var factory = new FooDbContextFactory();

            using (var context = factory.CreateDbContext())
            {
                context.Database.Migrate();

                var item = context.RelatedItems.Add(new RelatedEntity());
                var root = context.Roots.Add(new AggregateRoot { RelatedEntity = item.Entity });

                context.SaveChanges();
            }
        }
    }
}
