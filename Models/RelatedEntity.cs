using System;

namespace BenchmarkEfCore
{
    public class RelatedEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    }
}
