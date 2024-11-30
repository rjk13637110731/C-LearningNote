using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v = new Vector(1, 2, 3);
            Vector v1 = new Vector(2, 4, 6);
            double scale = 2.0;
            Console.WriteLine(v.Divide(v1));

            Console.WriteLine(v.Concat(v1));

            Console.WriteLine(v.SubVector(1,3));
        }
    }
}
