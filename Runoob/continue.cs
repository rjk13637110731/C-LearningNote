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
                if (a == 15)
                {
                    a = a + 1;
                    continue;
                }

                Console.WriteLine("a的值是：{0}", a);
                a++;
            } while (a < 20);
        }
    }
}
