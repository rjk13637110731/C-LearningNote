using System;

namespace ArrayApplication
{
    class MyArray
    {
        double getArray(int[] arr,int size)
        {
            int i;
            double avg;
            int sum = 0;
            for (i = 0;i < size;++i)
            {
                sum += arr[i];
            }

            avg = (double)sum / size;
            return avg;
        }

        public static void Main(string[] args)
        {
            MyArray app = new MyArray();
            int[] balance = new int[] { 1000, 2, 3, 17, 50 };
            double avg;
            avg = app.getArray(balance, 5);
            Console.WriteLine("平均值是：{0}",avg);
        }
    }
}
