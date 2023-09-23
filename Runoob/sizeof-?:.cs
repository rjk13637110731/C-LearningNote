using System;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("int 的大小是{0}",sizeof(int));
            Console.WriteLine("short 的大小是{0}",sizeof(short));
            Console.WriteLine("Double 的大小是{0}",sizeof(double));

            int a, b;
            a = 10;
            b = (a == 1) ? 20 : 30;
            Console.WriteLine("b 的值是{0}",b);

            b = (a == 10) ? 20 : 30;
            Console.WriteLine("b的值是{0}",b);
        }
    }
}
