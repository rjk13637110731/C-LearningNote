using System;

namespace PolymorphismApplication
{
    public class TestData{
        public int Add(int a,int b,int c)
        {
            return a + b + c;
        }

        public int Add(int a,int b)
        {
            return a + b;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            TestData dataClass = new TestData();
            int add1 = dataClass.Add(1, 2);
            int add2 = dataClass.Add(1, 2, 3);
            Console.WriteLine("add1 = {0}",add1);
            Console.WriteLine("add2 = {0}",add2);
        }
    }
}
