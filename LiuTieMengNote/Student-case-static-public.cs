using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stuList = new List<Student>();
            for (int i = 0; i < 100; i++)
            {
                Student stu = new Student();
                stu.Age = 24;
                stu.Score = i;
                stuList.Add(stu);
            }

            int totalAge = 0;
            int totalScore = 0;
            foreach (var stu in stuList)
            {
                totalAge += stu.Age;
                totalScore += stu.Score;
            }

            Student.AverageScore = totalScore / Student.Amount;
            Student.AverageAge = totalAge / Student.Amount;

            Student.ReportAmount(); // 100
            Student.ReportAverageAge(); // 24
            Student.ReportAverageScore(); // 49
        }
        class Student
        {
            //两个学生字段
            public int Age;
            public int Score;

            public static int AverageAge;
            public static int AverageScore;
            public static int Amount;

            // 构造函数
            public Student()
            {
                Student.Amount++;
            }

            // 静态方法
            public static void ReportAmount()
            {
                Console.WriteLine(Student.Amount);
            }

            public static void ReportAverageScore()
            {
                Console.WriteLine(Student.AverageScore);
            }

            public static void ReportAverageAge()
            {
                Console.WriteLine(Student.AverageAge);
            }
        }
    }
}
