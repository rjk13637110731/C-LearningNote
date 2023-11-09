using System;
using SupperCalculator;

namespace HelloWorld { 
    class Program
    {
        static void Main(string[] args)
        {
            double result1 = Class1.Add(10, 20);
            Console.WriteLine(result1);
            double result2 = Class1.Sub(10, 20);
            Console.WriteLine(result2);
            double result3 = Class1.Mul (10, 20);
            Console.WriteLine(result3);
            double result4 = Class1.Div(10, 20);
            Console.WriteLine(result4);
        }
    }
}
