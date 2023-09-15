using System;

namespace Test
{
    class Test
    {
        public static void Main(string[] args)
        {
            byte b = 10;
            int i = b;
            Console.WriteLine("i = {0}",i);

            int intValue = 42;
            long longValue = intValue;
            Console.WriteLine("longValue = {0}",longValue);

            int ii = 10;
            byte bb = (byte)i;
            Console.WriteLine("bb = {0}",bb);

            double doubleValue = 3.14;
            int intValue1 = (int)doubleValue;
            Console.WriteLine("intValue1 = {0}",intValue1);

            int intValue2 = 42;
            float floatValue = (float)intValue2;
            Console.WriteLine("floatValue = {0}",floatValue);

            int intValue4 = 123;
            string stringValue = intValue4.ToString();
            Console.WriteLine("stringValue = {0}",stringValue);

            double d = 5673.74;
            int i1;
            i1 = (int)d;
            Console.WriteLine("i1 = {0}",i1);

            int i2 = 75;
            float f = 53.005f;
            double d1 = 2345.7652;
            bool b1 = true;
            Console.WriteLine(i2.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d1.ToString());
            Console.WriteLine(b1.ToString());
        }
    }
}
