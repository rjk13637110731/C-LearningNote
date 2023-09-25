using System;

namespace Test
{
    class Rectangle
    {
        private double length;
        private double width;

        public void Acceptdetails()
        {
            Console.WriteLine("请输入长度：");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入宽度：");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("长度为：{0}",length);
            Console.WriteLine("宽度为：{0}",width);
            Console.WriteLine("面积为：{0}",GetArea());
        }
    }

    class ExecuteRectangle
    {
        public static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
        }
    }
}
