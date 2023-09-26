using System;

namespace Test
{
    class Line
    {
        private double length;

        public Line()
        {
            Console.WriteLine("对象以创建！");
        }

        public void setLength(double len)
        {
            length = len;
        }

        public double getLength()
        {
            return length;
        }

        public static void Main(string[] args)
        {
            Line line = new Line();
            line.setLength(6.0);
            Console.WriteLine(line.getLength());
        }
    }
}
