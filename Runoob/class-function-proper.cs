using System;

namespace BoxApplication
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;

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

        public double getVolume()
        {
            return length * breadth * height;
        }
    }

    class Boxtester
    {
        public static void Main(string[] args)
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);
            
            Box2.setLength(12.0);
            Box2.setBreadth(13.0);
            Box2.setHeight(10.0);

            double volume1 = Box1.getVolume();
            double volume2 = Box2.getVolume();
            Console.WriteLine("Box1的体积是：{0}",volume1);
            Console.WriteLine("Box2的体积是：{0}",volume2);
        }
    }
}
