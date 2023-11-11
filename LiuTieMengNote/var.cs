namespace ConstructorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = default(int);
            Console.WriteLine(x);

            double y = default(double);
            Console.WriteLine(y);

            String str = default(String);
            Console.WriteLine(str == null); // 引用数据类型默认值是null（空值）

            Level level = default(Level);
            Console.WriteLine(level); // 默认值：排在第一个的值，赋值为一个整数0，Low
        }
    }
    enum Level { 
        Low = 0,
        Mid = 1,
        High = 2
    }
}
