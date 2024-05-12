using System;
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
            int i, k;
            int[] myarr = new int[10];
            Random randomobj = new Random();
            for (i = myarr.GetLowerBound(0); i <= myarr.GetUpperBound(0); i++)
            {
                k = randomobj.Next() % 20;
                myarr.SetValue(k,i);
            }
            
            Console.WriteLine("随机数列：");

            for (i = myarr.GetLowerBound(0); i <= myarr.GetUpperBound(0); i++)
            {
                Console.Write("{0}\t",myarr.GetValue(i));
            }
            Console.WriteLine();

            Array.Sort(myarr);
            Console.WriteLine("随机数列排序后：");

            for (i = myarr.GetLowerBound(0); i <= myarr.GetUpperBound(0); i++)
            {
                Console.Write("{0}\t", myarr.GetValue(i));
            }
            Console.WriteLine();

        }
    }
}
