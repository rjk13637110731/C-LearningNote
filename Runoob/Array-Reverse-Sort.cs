using System;

namespace Test
{
    class MyArray
    {
        public static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            Console.Write("原始数组：");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            
            Array.Reverse(list);
            Console.Write("逆转数组：");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            
            Array.Sort(list);
            Console.Write("排序数组：");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
