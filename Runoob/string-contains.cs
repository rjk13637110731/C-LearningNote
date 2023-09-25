using System;

namespace Test
{
    class StringProgram
    {
        public static void Main(string[] args)
        {
            string str = "This is test.";
            if (str.Contains("test"))
            {
                Console.WriteLine("The sequence 'test' was found.");
            }
        }
    }
}
