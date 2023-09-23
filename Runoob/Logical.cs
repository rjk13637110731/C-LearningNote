using System;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool a = true;
            bool b = true;

            if (a && b)
            {
                Console.WriteLine("Line1 - 条件为真");
            }

            if (a || b)
            {
                Console.WriteLine("Line2 - 条件为真");
            }

            a = false;
            b = true;
            if (a && b)
            {
                Console.WriteLine("Line3 - 条件为真");
            }
            else
            {
                Console.WriteLine("Line3 - 条件为假");
            }

            if (!(a && b))
            {
                Console.WriteLine("Line4 - 条件为真");                
            }
            
            Console.ReadLine();
        }
    }
}
