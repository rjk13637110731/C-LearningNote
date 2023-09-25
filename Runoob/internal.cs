using  System;

namespace Test
{
    class Rectangle
    {
        internal double length;
        internal double width;

        double GetArea()
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
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
        }
    }
}
