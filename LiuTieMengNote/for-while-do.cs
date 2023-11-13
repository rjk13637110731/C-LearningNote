using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            // while循环
            int counter1 = 0;
            while (counter1 < 10)
            {
                Console.WriteLine("Hello World");
                counter1++;
            }

            Console.WriteLine("=======================================");

            // do循环
            int counter2 = 0;
            do
            {
                Console.WriteLine("HEllo World");
                counter2++;
            } while (counter2 < 10);

            Console.WriteLine("=======================================");

            // for循环
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello World");
            }
        }
    }
}
