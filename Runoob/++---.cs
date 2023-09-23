using System;

namespace test
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 1;
            int b;

            b = a++;
            Console.WriteLine("a = {0},b = {1}",a,b);

            a = 1;
            b = ++a;
            Console.WriteLine("a = {0},b = {1}",a,b);
            
            a = 1;
            b = a--;
            Console.WriteLine("a = {0},b = {1}",a,b);
            
            a = 1;
            b = --a;
            Console.WriteLine("a = {0},b = {1}",a,b);
            Console.ReadLine();
        }
    }
}

