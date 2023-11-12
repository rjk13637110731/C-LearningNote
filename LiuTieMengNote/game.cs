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
            int score = 0;
            bool canContinue = true;
            while (canContinue)
            {
                Console.WriteLine("Please input first number:");
                string str1 = Console.ReadLine();
                int x = int.Parse(str1);

                Console.WriteLine("Please input second number:");
                string str2 = Console.ReadLine();
                int y = int.Parse(str2);

                int sum = x + y;
                if (sum == 100)
                {
                    score++;
                    Console.WriteLine("Correct!{0} + {1} = {2}", x, y, sum);
                }
                else
                {
                    Console.WriteLine("Error! {0} + {1} = {2}", x, y, sum);
                    canContinue = false;
                }
            }
            Console.WriteLine("Your score is {0}",score);
            Console.WriteLine("Game Over!");
        }
    }
}
