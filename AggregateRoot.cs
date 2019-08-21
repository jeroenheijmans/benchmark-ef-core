using System;
using System.ComponentModel.DataAnnotations;

namespace BenchmarkEfCore
{
    public class AggregateRoot
    {
        public Guid Id { get; set; }
        public string Foo0 { get; set; } = "Default Default Default Default";
        public string Foo1 { get; set; }
        public string Foo2 { get; set; }
        public string Foo3 { get; set; }
        public string Foo4 { get; set; }
        public string Foo5 { get; set; }
        [StringLength(100)]
        public string Foo6 { get; set; } = "Dummy dummy dummy " + Guid.NewGuid().ToString();
        [StringLength(1000)]
        public string Foo7 { get; set; }
        [StringLength(250)]
        public string Foo8 { get; set; }
        [StringLength(200)]
        public string Foo9 { get; set; }
        public bool Bar0 { get; set; } = true;
        public bool Bar1 { get; set; }
        public bool Bar2 { get; set; }
        public bool? Bar3 { get; set; } = true;
        public bool? Bar4 { get; set; }
        public int Baz0 { get; set; } = 42;
        public int Baz1 { get; set; }
        public int Baz2 { get; set; }
        public int Baz3 { get; set; }
        public int? Baz4 { get; set; } = 9001;
        public int? Baz5 { get; set; }
        public Option OptionA { get; set; } = Option.A;
        public Option OptionB { get; set; } = Option.B;
        public Option OptionC { get; set; } = Option.C;
        public Option? OptionD { get; set; } = Option.D;
        public Option? OptionE { get; set; }
        public Option? OptionF { get; set; }
        public DateTimeOffset Stamp1 { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset Stamp2 { get; set; }
        public DateTimeOffset Stamp3 { get; set; }
        public DateTimeOffset? Stamp4 { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset? Stamp5 { get; set; }
        public RelatedEntity RelatedEntity { get; set; }
        public ChildOne ChildOne { get; set; } = new ChildOne();
        public ChildTwo ChildTwo1 { get; set; } = new ChildTwo();
        public ChildTwo ChildTwo2 { get; set; } = new ChildTwo();
        public ChildTwo ChildTwo3 { get; set; } = new ChildTwo();
        public ChildTwo ChildTwo4 { get; set; } = new ChildTwo();
    }
}
