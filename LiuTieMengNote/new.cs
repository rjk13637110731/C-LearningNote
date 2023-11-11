using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form myForm = new Form() { Text = "Hello"};
            myForm.ShowDialog();
        }
    }
}
