using System;

namespace BoxApplication
{
    class Box
    {
        public double length;
        public double width;
        public double height;
    }

    class Boxtester
    {
        public static void Main(string[] args)
        {
            Box Box1 = new Box();
            Box Box2 = new Box();
            double volume = 0.0;

            Box1.length = 5.0;
            Box1.width = 6.0;
            Box1.height = 7.0;

            Box2.length = 10.0;
            Box2.width = 12.0;
            Box2.height = 13.0;

            volume = Box1.height * Box1.width * Box1.length;
            Console.WriteLine("Box1 的体积是：{0}",volume);
            volume = Box2.height * Box2.width * Box2.length;
            Console.WriteLine("Box2 的体积是：{0}",volume);
        }
    }
}
