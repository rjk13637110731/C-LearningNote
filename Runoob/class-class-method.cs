using System;

namespace Test
{
    class NumberManipulator
    {
        public int FindMax(int num1,int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }
    }

    class Test
    {
        public static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            int ret;
            NumberManipulator n = new NumberManipulator();
            ret = n.FindMax(a, b);
            Console.WriteLine("最大值是：{0}",ret);
        }
    }
}
