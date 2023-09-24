using System;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 10;

            do
            {
                Console.WriteLine("a的值是：{0}", a);
                a += 1;
            } while (a < 20);
        }
    }
}
