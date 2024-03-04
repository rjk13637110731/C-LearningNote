using System;
using System.IO;

namespace SPH_ConsoleApp {
    class Program {
        // 快捷键 svm + tab键两次
        static void Main(string[] args)
        {
            /// 申请临时变量
            /// 这些临时变量并不是必须的，但是此程序用于授课
            /// 正式变量太长了，授课的时候，语句可能跳出显式屏幕之外
            double t1, t2, t3, t4;

            /// 申明自变量 x 数组
            double[] xArray = new double[6];

            /// 申明因变量 y 数组，用于存储数值解；第一种差分格式
            double[] y1ArrayNumericalSolution = new double[xArray.Length];

            /// 申明因变量 y 数组，用于存储数值解；第二种差分格式
            double[] y2ArrayNumericalSolution = new double[xArray.Length];

            /// 申明因变量 y 数组，用于存储解析解
            double[] yArrayAnalyticSolution = new double[xArray.Length];

            /// 设置输出文件的存储路径
            string path = AppDomain.CurrentDomain.BaseDirectory + "SPHtxt.txt";

            /// 设置计算区间
            double[] arrayComputationalDomain = new double[2];
            arrayComputationalDomain[0] = 0;
            arrayComputationalDomain[1] = 2.0 * Math.PI;

            /// 设置计算步长
            double span;
            t1 = arrayComputationalDomain[0];
            t2 = arrayComputationalDomain[1];
            t3 = xArray.Length - 1;
            span = (t2 - t1) / t3;

            /// 设置边界条件
            xArray[0] = 0;
            yArrayAnalyticSolution[0] = 0;
            y1ArrayNumericalSolution[0] = 0;
            y2ArrayNumericalSolution[0] = 0;

            /// 给 xArray 数组赋值
            for (int i = 1; i < xArray.Length; i++)
            {
                xArray[i] = xArray[i - 1] + span;
            }

            /// 给第一种差分格式，计算y的近似值
            for (int i = 1;i < xArray.Length; i++)
            {
                t1 = xArray[i - 1];
                t2 = y1ArrayNumericalSolution[i - 1];
                t3 = Math.Sin(t1);
                t4 = t2 + t3 * span;
                y1ArrayNumericalSolution[i] = t4;
            }

            /// 给第二种差分格式，计算y的近似值
            for (int i = 1; i < xArray.Length; i++)
            {
                t1 = (xArray[i - 1] + xArray[i])/2.0;
                t2 = y2ArrayNumericalSolution[i - 1];
                t3 = Math.Sin(t1);
                t4 = t2 + t3 * span;
                y2ArrayNumericalSolution[i] = t4;
            }

            /// 计算解析解
            for (int i = 0; i < xArray.Length; i++)
            {
                t1 = xArray[i];
                t2 = 1.0 - Math.Cos(t1);
                yArrayAnalyticSolution[i] = t2;
            }

            try
            {
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }

                FileStream stream = System.IO.File.Create(path);
                stream.Close();
                stream.Dispose();

                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    // 输出结果
                    for (int i = 0;i < xArray.Length;i++)
                    {
                        t1 = xArray[i];
                        t2 = yArrayAnalyticSolution[i];
                        t3 = y1ArrayNumericalSolution[i];
                        t4 = y2ArrayNumericalSolution[i];

                        string temps = t1.ToString() + "\t" + t2.ToString() + "\t" + t3.ToString() + "\t" + t4.ToString();
                        writer.WriteLine(temps);
                    }
                }
            }
            catch
            {
                Console.WriteLine("文件输入失败");
            }
            Console.WriteLine("\t计算域：{0} \t 数组长度{1}\n\n\t输出文件存储地址：{2}",Math.PI*2,xArray.Length,path);
        }
    }
}
