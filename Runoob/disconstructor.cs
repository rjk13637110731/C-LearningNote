using System;

namespace LineApplication
{
    class Line
    {
        private double length;

        public Line()
        {
            Console.WriteLine("对象以创建！");
        }

        ~Line()
        {
            Console.WriteLine("对象已删除");
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
            Console.WriteLine("线条长度为：{0}",line.getLength());
        }
    }
}
