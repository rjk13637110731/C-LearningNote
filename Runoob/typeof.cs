using System;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            Type type = typeof(string);
            Console.WriteLine(type.FullName);
            Console.ReadLine();
        }
    }
}
