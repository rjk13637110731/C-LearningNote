using System;

namespace Program
{
    class MyClass
    {
        public static void Main(string[] args)
        {
            int i, j;
            for (i = 2;i < 100;i++) {
                for (j = 2;j <= (i/j);j++) {
                    if ((i%j) == 0)
                    {
                        break;
                    }
                }
                
                if (j > (i/j))
                {
                    Console.WriteLine("{0}是质数",i);
                }
            }
        }
    }
}
