using System;

namespace Test
{
    class NumberManipulator
    {
        public void swap(ref int x,ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

        public static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a = 10;
            int b = 20;
            Console.WriteLine("交换前 a = {0}",a);
            Console.WriteLine("交换前 b = {0}",b);
            n.swap(ref a,ref b);
            Console.WriteLine("交换后 a = {0}",a);
            Console.WriteLine("交换后 b = {0}",b);
        }
    }
}
