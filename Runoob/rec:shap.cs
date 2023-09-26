using System;

namespace Test
{
    class Shape
    {
        protected int width;
        protected int height;
        
        public void setWidth(int w)
        {
            width = w;
        }

        public void setHeight(int h)
        {
            height = h;
        }
    }

    class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }

    class RectangleTest
    {
        public static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            Rect.setWidth(5);
            Rect.setHeight(7);
            Console.WriteLine("总面积为：{0}",Rect.getArea());
        }
    }
}
