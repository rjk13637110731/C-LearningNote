using System;

namespace Test
{
    class Enumlist
    {
        enum Day
        {
            Sun,
            Mon,
            Tue,
            Wed,
            Thu,
            Fri,
            Sat
        };

        public static void Main(string[] args)
        {
            int x = (int)Day.Sun;
            int y = (int)Day.Fri;
            Console.WriteLine("Sun = {0}",x);
            Console.WriteLine("Fri = {0}",y);
        }
    }
}
