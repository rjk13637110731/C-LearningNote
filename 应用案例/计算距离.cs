using System;

namespace _001_开始
{
    class Program
    {
        static void Main(string[] args)
        {
            // 水平放置弹体-爆心
            double[] H_xyzRoom1 = { 2.0, 0.0, 1.25 };

            // 监测点处坐标
            double[] H_pointCenterUp = { 3.5, 1.0, 1.25 };
            double[] H_pointCenterDown = { 3.5, 1.0, 0.5 };
            double[] H_pointSideUp = { 3.5, 0.5, 1.25 };
            double[] H_pointSideDown = { 3.5, 0.5, 0.5 };

            double[][] H_pointAll = { H_pointCenterUp, H_pointCenterDown, H_pointSideUp, H_pointSideDown };

            // 计算距离爆心处的距离
            double[] LengthBoomPoint = new double[4];
            for (int i = 0; i < 4; i++)
            {
                double dx2 = (H_xyzRoom1[0] - H_pointAll[i][0]) * (H_xyzRoom1[0] - H_pointAll[i][0]);
                double dy2 = (H_xyzRoom1[1] - H_pointAll[i][1]) * (H_xyzRoom1[1] - H_pointAll[i][1]);
                double dz2 = (H_xyzRoom1[2] - H_pointAll[i][2]) * (H_xyzRoom1[2] - H_pointAll[i][2]);
                LengthBoomPoint[i] = Math.Sqrt(dx2 + dy2 + dz2);
            }

            // 输出计算四个监测点的距离爆心距离的结果
            for (int i = 0; i < 4; i++)
            {
                Console.Write(LengthBoomPoint[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
