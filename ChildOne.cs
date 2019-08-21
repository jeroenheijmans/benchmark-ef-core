using System.Collections.Generic;

namespace BenchmarkEfCore
{
    public class ChildOne
    {
        public string Foo0 { get; set; } = "Foo bar foo bar foo bar";
        public string Foo1 { get; set; }
        public string Foo2 { get; set; }
        public string Foo3 { get; set; }
        public string Foo4 { get; set; }
        public string Foo5 { get; set; }
        public string Foo6 { get; set; }
        public string Foo7 { get; set; }
        public string Foo8 { get; set; }
        public string Foo9 { get; set; }
        public bool Bar0 { get; set; } = true;
        public bool Bar1 { get; set; }
        public bool Bar2 { get; set; }
        public bool? Bar3 { get; set; } = true;
        public bool? Bar4 { get; set; }
        public int Baz0 { get; set; } = 123;
        public int Baz1 { get; set; }
        public int Baz2 { get; set; }
        public int Baz3 { get; set; }
        public int? Baz4 { get; set; } = 99999;
        public int? Baz5 { get; set; }
        public Option OptionA { get; set; } = Option.A;
        public Option OptionB { get; set; } = Option.B;
        public Option OptionC { get; set; } = Option.C;
        public Option? OptionD { get; set; } = Option.D;
        public Option? OptionE { get; set; }
        public Option? OptionF { get; set; }
        public List<ValueObject> OwnedValueObjects { get; set; } = new List<ValueObject>();
    }
}
