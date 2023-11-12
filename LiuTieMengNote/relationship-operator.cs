using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            double y = 4.0;
            var result1 = x > y;
            Console.WriteLine(result1.GetType().Name); //Boolean
            Console.WriteLine(result1); //True
            
            var result2 = x >= y;
            Console.WriteLine(result2); //True

            var result3 = x < y;
            Console.WriteLine(result3); //False

            var result4 = x <= y;
            Console.WriteLine(result4); //False

            var result5 = x == y;
            Console.WriteLine(result5); //False

            var result6 = x != y;
            Console.WriteLine(result6); //True
        }
    }
}
