using System; // 这里不是语句，是指令
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            int r = 0;
            try // Main函数调用，Main函数处理throw抛出的异常
            {
                r = c.Add(null, "200");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            Console.WriteLine(r);
        }
    }
    class Calculator
    {
        public int Add(string arg1, string arg2)
        {
            int a = 0;
            int b = 0;
            try
            {
                a = int.Parse(arg1);
                b = int.Parse(arg2);
            }
            catch (ArgumentException ane) // ane为异常的标识符
            {
                Console.WriteLine(ane.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (OverflowException oe)
            {
                //Console.WriteLine(oe.Message);
                throw oe; // 谁调用谁处理
            }

            int result = a + b;
            return result;
        }
    }
}
