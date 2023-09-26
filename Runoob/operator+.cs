using System;

namespace Test
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;

        public double getVolume()
        {
            return length * breadth * height;
        }

        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }
        public void setHeight(double hei)
        {
            height = hei;
        }

        public static Box operator +(Box b,Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.height = b.height + c.height;
            box.breadth = b.breadth + c.breadth;
            return box;
        }
    }

    class Test
    {
        public static void Main(string[] args)
        {
            Box b1 = new Box();
            Box b2 = new Box();
            Box b3 = new Box();
            double volume = 0;
            
            b1.setLength(6.0);
            b1.setBreadth(7.0);
            b1.setHeight(5.0);
            b2.setLength(12.0);
            b2.setBreadth(13.0);
            b2.setHeight(10.0);

            volume = b1.getVolume();
            Console.WriteLine("Box1的体积是：{0}",volume);
            volume = b2.getVolume();
            Console.WriteLine("Box2的体积是：{0}",volume);

            b3 = b1 + b2;
            volume = b3.getVolume();
            Console.WriteLine("Box3的体积是：{0}",volume);
        }
    }
}
