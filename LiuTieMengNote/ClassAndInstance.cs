namespace ClassAndInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            int x = c.Add(10, 20);
            Console.WriteLine(x);

            string str = c.Today();
            Console.WriteLine(str);

            c.PrintSum(4,6);
        }
    }

    class Calculator 
    {
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
        public string Today() 
        {
            int day = DateTime.Now.Day;
            return day.ToString();
        }

        public void PrintSum(int a, int b) { 
            int result = a + b;
            Console.WriteLine(result);
        }
    }
}

//30
//10
//10
