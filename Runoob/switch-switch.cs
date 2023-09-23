using System;

namespace MyAppplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            switch (a)
            {
                case 100:
                    Console.WriteLine("这是外部的Switch语句");
                    switch (b)
                    {
                        case 200:
                            Console.WriteLine("这是内部的Switch语句");
                            break;
                    }
                    break;
            }
            Console.WriteLine("a的准确值是{0}",a);
            Console.WriteLine("b的准确值是{0}",b);
        }
    }
}
