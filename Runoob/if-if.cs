using System;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 100;
            int b = 200;

            if (a == 100)
            {
                if (b == 200)
                {
                    Console.WriteLine("a的值是100，b的值是200");
                }
            }
            Console.WriteLine("a的准确值是{0}",a);
            Console.WriteLine("b的准确值是{0}",b);
        }
    }
}
