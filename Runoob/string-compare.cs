using System;

namespace Test
{
    class StringPro
    {
        public static void Main(string[] args)
        {
            string str1 = "This is Test";
            string str2 = "This is Text";

            if (string.Compare(str1,str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }
        }
    }
}
