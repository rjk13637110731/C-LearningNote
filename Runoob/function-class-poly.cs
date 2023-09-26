using System;

namespace PApplication
{
    class PrintData
    {
        void print(int i)
        {
            Console.WriteLine("输出整型：{0}",i);
        }
        
        void print(double f)
        {
            Console.WriteLine("输出浮点型：{0}",f);
        }
        void print(string s)
        {
            Console.WriteLine("输出字符串：{0}",s);
        }

        public static void Main(string[] args)
        {
            PrintData p = new PrintData();
            p.print(1);
            p.print(1.23);
            p.print("Hello World!");
        }
    }
}
