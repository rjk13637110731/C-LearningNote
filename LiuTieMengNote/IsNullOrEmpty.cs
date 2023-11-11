using System;
using System.Collections.Generic;
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
            Student stu = new Student(null);
            Console.WriteLine(stu.Name);
        }
    }
    class Student {

        public Student(string initName)
        {
            if (!string.IsNullOrEmpty(initName))
            {
                this.Name = initName;
            }
            else {
                throw new ArgumentException("initName cannot be null or empty!");
            }
        }
        public string Name;
    }
}
