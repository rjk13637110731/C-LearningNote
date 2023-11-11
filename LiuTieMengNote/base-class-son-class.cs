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
            Teacher t = new Teacher();
            Human h = t;   //子类向父类隐式转换
            Animal a = h;  //子类向父类隐式转换
            a.Eat();
        }
    }
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    class Human : Animal
    {
        public void Think()
        {
            Console.WriteLine("Who I am?");
        }
    }
    class Teacher : Human
    {
        public void Teach()
        {
            Console.WriteLine("I teach programming.");
        }
    }
}

// Eating...
