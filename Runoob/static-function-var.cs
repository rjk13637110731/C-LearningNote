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

        public static int getNum()
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
            Console.WriteLine("变量num: {0}",StaticVar.getNum());
            Console.WriteLine("变量num: {0}",StaticVar.getNum());
        }
    }
}
