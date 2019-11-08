using System;

namespace OverrideNew
{
    class Base {
        public virtual void V() => Console.WriteLine("V"); // virtual method
        public void I() => Console.WriteLine("I"); // instance method
    }
    class Super : Base
    {
        public override void V() => Console.WriteLine("override!");
        public new void I() => Console.WriteLine("new!");
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base(); b.V(); b.I();
            Console.WriteLine();

            Super s = new Super(); s.V(); s.I();
            Console.WriteLine();

            Base bs = new Super(); bs.V(); bs.I();
            Console.WriteLine();
        }
    }
}
