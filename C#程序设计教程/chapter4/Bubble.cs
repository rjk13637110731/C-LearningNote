using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Bubble();
        }

        private void Bubble()
        {
            int[] NumArr = new int[] { 29, 89, 65, 36, 10, 21, 48, 77, 58 };
            for (int i = 0; i < NumArr.Length - 1; i++)
            {
                for (int j = 0; j < NumArr.Length - 1 - i; j++)
                {
                    if (NumArr[j] > NumArr[j + 1])
                    {
                        int temp = NumArr[j];
                        NumArr[j] = NumArr[j + 1];
                        NumArr[j + 1] = temp;
                    }
                }
            }
            // 输出
            for (int i = 0; i < NumArr.Length; i++)
            {
                Console.Write(NumArr[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
