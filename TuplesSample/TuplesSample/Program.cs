using System;

namespace TuplesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample1();
            Deconstruction();
        }

        private static void Deconstruction()
        {
            var b1 = new Book("Professional C# 7", "Wrox Press");
            (string title, _) = b1;
            Console.WriteLine(title);
        }

        private static void Sample1()
        {
            var t1 = Tuple.Create(42, "abc");
            // t1.Item1 = 11;  // immutable


            var t2 = (x: 42, s: "abc");  // tuple
            t2.x = 11;

            int a = 3;
            a = 4;

            (int x, string s) = t2;  // deconstruction
            
        }
    }
}
