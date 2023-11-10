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
        int result = 0;
        public int SumFrom1ToX(int x) {
            if (x == 1) {
                return 1 ;
            }
            else {
                result = x + SumFrom1ToX(x - 1);
                return result;
            }
        }
    }
}
//5050
