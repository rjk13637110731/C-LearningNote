using System;

namespace Test
{
    class NumberManipulator
    {
        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }

        public static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a = 100;
            
            Console.WriteLine("在方法调用前，a = {0}",a);
            n.getValue(out a);
            Console.WriteLine("方法调用后a = {0}",a);
        }
    }
}
