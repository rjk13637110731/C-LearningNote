using System;

namespace Test
{
    class NumberManipulator
    {
        public int factorial(int num)
        {
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }

        public static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            Console.WriteLine("6的阶乘是：{0}",n.factorial(6));
            Console.WriteLine("7的阶乘是：{0}",n.factorial(7));
            Console.WriteLine("8的阶乘是：{0}",n.factorial(8));
        }
    }
}
