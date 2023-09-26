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

    public interface PaintCost
    {
        int getCost(int area);
    }

    class Rectangle : Shape, PaintCost
    {
        public int getArea()
        {
            return width * height;
        }

        public int getCost(int area)
        {
            return area * 70;
        }
    }

    class RectangleTest
    {
        public static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            int area;
            r.setHeight(7);
            r.setWidth(5);
            area = r.getArea();
            Console.WriteLine("总面积是：{0}",r.getArea());
            Console.WriteLine("油漆总成本：{0}",r.getCost(area));
        }
    }
}
