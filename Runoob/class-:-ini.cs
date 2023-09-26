using System;

namespace Test
{
    class Rectangle
    {
        protected double width;
        protected double length;

        public Rectangle(double l,double w)
        {
            width = w;
            length = l;
        }

        public double getArea()
        {
            return length * width;
        }

        public void display()
        {
            Console.WriteLine("长度：{0}",length);
            Console.WriteLine("宽度：{0}",width);
            Console.WriteLine("面积：{0}",getArea());
        }
    }

    class Tabletop : Rectangle
    {
        private double cost;

        public Tabletop(double l, double w) : base(l, w)
        {
        }

        public double getCost()
        {
            double cost;
            cost = getArea() * 70;
            return cost;
        }

        public void display()
        {
            base.display();
            Console.WriteLine("成本：{0}",getCost());
        }
    }

    class RectangleTest
    {
        public static void Main(string[] args)
        {
            Tabletop t = new Tabletop(4.5, 7.5);
            t.display();
        }
    }
}
