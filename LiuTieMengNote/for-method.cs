namespace SumNum {
    class Program { 
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            int result = c.SumFrom1ToX(100);
            Console.WriteLine(result);
        }
    }

    class Calculator {
        public int SumFrom1ToX(int x) {
            int result = 0;
            for (int i = 1; i < x+1; i++)
            {
                result = result + i;
            }
            return result;
        }
    }
}
//5050
