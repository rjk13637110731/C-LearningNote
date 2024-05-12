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
            p1.setpoint(2, 6);
            Console.Write("第一个点 => ");
            p1.disppoint();

            TPoint p2 = new TPoint();
            p2.setpoint(8,3);
            Console.Write("第二个点 => ");
            p2.disppoint();
        }
    }

    public class TPoint 
    {
        int x, y;

        public void setpoint(int x1,int y1) 
        {
            x = x1;
            y = y1;
        }

        public void disppoint() 
        {
            Console.WriteLine("{0},{1}", x, y);
        }
    }
}
