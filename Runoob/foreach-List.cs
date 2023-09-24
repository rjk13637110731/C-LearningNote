using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> myStrings = new List<string>();
            
            myStrings.Add("Google");
            myStrings.Add("Runoob");
            myStrings.Add("Taobao");

            foreach (string s in myStrings)
            {
                Console.WriteLine(s);
            }
        }
    }
}
