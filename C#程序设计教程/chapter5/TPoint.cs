using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TPoint p1 = new TPoint();
            Console.WriteLine("第一个点：");
            p1.dispoint();
            TPoint p2 = new TPoint(8,13);
            Console.WriteLine("第二个点：");
            p2.dispoint();
        }
    }

    public class TPoint 
    {
        int x, y;
        public TPoint() { }
        public TPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void dispoint()
        {
            Console.WriteLine("{0},{1}",x,y);
        }
    }
}
