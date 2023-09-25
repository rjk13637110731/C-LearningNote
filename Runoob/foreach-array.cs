using System;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] n = new int[10];
            for (int i = 0;i < 10;i++)
            {
                n[i] = i*i;
            }

            foreach (int j in n)
            {
                int i = j - j * j / 2;
                Console.WriteLine("Element[{0}] = {1}",i,j);
            }
        }
    }
}
