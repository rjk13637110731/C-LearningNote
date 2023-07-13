using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj1_1{
    class Program {
        static void Main(String[] args)
        {
            int a, b, c;
            Console.Write("a:");
            a = int.Parse(Console.ReadLine());

            Console.Write("b:");
            b = int.Parse(Console.ReadLine());

            c = a + b;

            Console.WriteLine("a+b = {0}",c);
        }
    }
}
