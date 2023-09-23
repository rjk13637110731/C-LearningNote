using System;

namespace EscapeChar
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello\tWorld\n\n");
            string a = "Hello\tWorld!\n";
            string b = @"Hello\tWorld\n";
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
