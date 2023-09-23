using System;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 21;
            int b = 10;

            if (a == b)
            {
                Console.WriteLine("Line1 - a 等于 b");
            }
            else
            {
                Console.WriteLine("Line1 - a 不等于 b");
            }

            if (a < b)
            {
                Console.WriteLine("Line2 - a 小于 b");
            }
            else
            {
                Console.WriteLine("Line2 - a 不小于 b");
            }
            if (a > b)
            {
                Console.WriteLine("Line3 - a 大于 b");
            }
            else
            {
                Console.WriteLine("Line3 - a 不大于 b");
            }

            a = 5;
            b = 20;
            if (a <= b)
            {
                Console.WriteLine("Line4 - a 小于或等于 b");
            }
            if (a >= b)
            {
                Console.WriteLine("Line5 - a 大于或等于 b");
            }

            Console.ReadLine();
        }
    }
}
