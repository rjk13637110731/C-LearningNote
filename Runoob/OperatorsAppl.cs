using System;

namespace OperatorsAppl
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 21;
            int b = 10;
            int c;

            c = a + b;
            Console.WriteLine("Line 1-c 的值是{0}",c);
            c = a - b;
            Console.WriteLine("Line 2-c 的值是{0}",c);
            c = a * b;
            Console.WriteLine("Line 3-c 的值是{0}",c);
            c = a / b;
            Console.WriteLine("Line 4-c 的值是{0}",c);
            c = a % b;
            Console.WriteLine("Line 5-c 的值是{0}",c);
            c = ++a;
            Console.WriteLine("Line 6-c 的值是{0}",c);
            c = --a;
            Console.WriteLine("Line 7-c 的值是{0}",c);
        }
    }
}
