#define PI
using System;

namespace PreprocessorApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            #if(PI)
                Console.WriteLine("PI is defined");
            #else
                Console.WriteLine("PI is not defined");
            #endif
            Console.WriteLine("结束判断！");
        }
    }
}
