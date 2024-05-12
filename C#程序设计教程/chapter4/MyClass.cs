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
            MyClass s = new MyClass();
            s.setstr("Marry");
            Console.WriteLine("s.str = {0}", s.getstr());

            MyClass t = new MyClass();
            t.setstr("Smith");
            Console.WriteLine("t.str = {0}", t.getstr());

            t = s;
            Console.WriteLine("执行 t=s");
            Console.WriteLine("t.str = {0}", t.getstr());
        }
    }

    public class MyClass 
    {
        string str;

        public void setstr(string mystr) 
        {
            str = mystr;
        }

        public string getstr() 
        {
            return str;
        }
    }
}
