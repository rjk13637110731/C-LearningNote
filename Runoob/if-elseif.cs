using System;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 100;
            if (a == 10)
            {
                Console.WriteLine("a 的值是10");
            }else if(a == 20)
            {
                Console.WriteLine("a的值是20");
            }else if (a == 30)
            {
                Console.WriteLine("a的值是30");
            }
            else
            {
                Console.WriteLine("没有匹配的值");
            }
            Console.WriteLine("a的准确值是{0}",a);
        }
    }
}
