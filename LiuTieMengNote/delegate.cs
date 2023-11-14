using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
{
    // 自定义委托类的声明
    public delegate double Calc(double x, double y);

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Calc calc1 = new Calc(calculator.Add);
            Calc calc2 = new Calc(calculator.Sub);
            Calc calc3 = new Calc(calculator.Mul);
            Calc calc4 = new Calc(calculator.Div);

            double a = 100;
            double b = 200;
            double c = 0;

            c = calc1.Invoke(a, b);
            Console.WriteLine(c);
            // 等价于
            c = calc1(a,b);
            Console.WriteLine(c);
            Console.WriteLine("=====================");
            
            c = calc2.Invoke(a, b);
            Console.WriteLine(c);
            // 等价于
            c = calc2(a, b);
            Console.WriteLine(c);
            Console.WriteLine("=====================");
            
            c = calc3.Invoke(a, b);
            Console.WriteLine(c);
            // 等价于
            c = calc3(a, b);
            Console.WriteLine(c);
            Console.WriteLine("=====================");

            c = calc4.Invoke(a, b);
            Console.WriteLine(c);
            // 等价于
            c = calc4(a, b);
            Console.WriteLine(c);
        }
    }

    class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }

        public double Mul(double x, double y)
        {
            return x * y;
        }

        public double Div(double x, double y)
        {
            return x / y;
        }
    }
}
