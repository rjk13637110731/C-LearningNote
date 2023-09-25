using System;

namespace Test
{
    class ArrayTest
    {
        public int AddElements(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }

            return sum;
        }
    }

    class TestClass
    {
        public static void Main(string[] args)
        {
            ArrayTest app = new ArrayTest();
            int sum = app.AddElements(512, 720, 250, 567, 889);
            Console.WriteLine("总和是：{0}",sum);
        }
    }
}
