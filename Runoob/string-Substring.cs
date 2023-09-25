using System;

namespace Test
{
    class StringTest
    {
        public static void Main(string[] args)
        {
            string str = "Last night I dreamt of San Pedro.";
            Console.WriteLine(str);
            string substr = str.Substring(23);
            Console.WriteLine(substr);
        }
    }
}
