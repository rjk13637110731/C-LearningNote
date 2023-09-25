using System;

namespace Test
{
    class Number
    {
        public void getValue(out int x,out int y)
        {
            Console.WriteLine("请输入第一个值：");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个值：");
            y = Convert.ToInt32(Console.ReadLine());
        }

        public static void Main(string[] args)
        {
            Number n = new Number();
            int a, b;
            n.getValue(out a,out b);
            Console.WriteLine("在调用之后a = {0}",a);
            Console.WriteLine("在调用之后b = {0}",b);
        }
    }
}
