using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myarr = new ArrayList();
            myarr.Add("Smith");
            myarr.Add("Mary");
            myarr.Add("Dava");
            myarr.Add("john");

            Console.WriteLine("排序前序列：");
            foreach (String sname in myarr)
            {
                Console.Write(sname + "\t");
            }
            Console.WriteLine();

            myarr.Sort();

            Console.WriteLine("排序后序列：");
            foreach (String sname in myarr)
            {
                Console.Write(sname + "\t");
            }
            Console.WriteLine();
        }
    }
}
