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
            Student stu = new Student();
            stu["Math"] = 90;
            stu["Math"] = 100;
            var mathScore = stu["Math"];
            Console.WriteLine(mathScore == null);
            Console.WriteLine(mathScore);
        }

    }

    class Student
    {
        private Dictionary<string, int> scoreDictionary = new Dictionary<string, int>(); //私有字段

        // 创建getter与setter快捷操作：indexer + 两次Tab键 + 回车
        public int? this[string subject]
        {
            get
            {
                if (this.scoreDictionary.ContainsKey(subject))
                {
                    return this.scoreDictionary[subject];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                // 保护措施
                if (value.HasValue == false)
                {
                    throw new Exception("Score cannot be null.");
                }

                if (this.scoreDictionary.ContainsKey(subject))
                {
                    this.scoreDictionary[subject] = value.Value;
                }
                else
                {
                    this.scoreDictionary.Add(subject, value.Value);
                }
            }
        }
    }
}
