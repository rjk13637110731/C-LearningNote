using System;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 10;

            while (a < 20)
            {
                Console.WriteLine("a的值为：{0}",a);
                a++;
                if (a > 15)
                {
                    break;
                }
            }
        }
    }
}
