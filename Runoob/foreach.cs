using System;

namespace Loops
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int i in fibarray)
            {
                Console.WriteLine(i);
            }

            for (int i = 0;i < fibarray.Length;i++) {
                Console.WriteLine(fibarray[i]);
            }

            int count = 0;
            foreach (int element in fibarray)
            {
                count += 1;
                Console.WriteLine("Element #{0}:{1}",count,element);
            }
            Console.WriteLine("Number of elements in the array:{0}",count);
        }
    }
}
