using System;

namespace Test
{
    class StaticVar
    {
        public static int num;

        public void count()
        {
            num++;
        }

        public int getNum()
        {
            return num;
        }
    }

    class StaticTester
    {
        public static void Main(string[] args)
        {
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();
            s1.count();
            s1.count();
            s1.count();
            s2.count();
            s2.count();
            s2.count();
            Console.WriteLine("s1的变量num: {0}",s1.getNum());
            Console.WriteLine("s2的变量num: {0}",s2.getNum());
        }
    }
}
