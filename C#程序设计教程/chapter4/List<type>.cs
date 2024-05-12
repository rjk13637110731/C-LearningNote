using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    struct Stud 
    {
        public int sno;
        public string sname;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Stud> myset = new List<Stud>();

            Stud s1 = new Stud();
            s1.sno = 101;
            s1.sname = "李明";
            myset.Add(s1);

            Stud s2 = new Stud();
            s2.sno = 103;
            s2.sname = "王华";
            myset.Add(s2);

            Stud s3 = new Stud();
            s3.sno = 108;
            s3.sname = "张英";
            myset.Add(s3);

            Stud s4 = new Stud();
            s4.sno = 101;
            s4.sname = "张伟";
            myset.Add(s4);

            Console.WriteLine("元素序列：'");
            Console.WriteLine("\t下标\t学号\t姓名");

            int i = 0;
            foreach (Stud s in myset)
            {
                Console.WriteLine("\t{0}\t{1}\t{2}",i,s.sno,s.sname);
                i++;
            }

            Console.WriteLine("容量：{0}", myset.Capacity);
            Console.WriteLine("容量：{0}", myset.Count);
            Console.WriteLine("在索引2处插入一个元素：");
            Stud s5 = new Stud();
            s5.sno = 106;
            s5.sname = "陈兵";
            myset.Insert(2, s5);

            Console.WriteLine("元素序列：");

            Console.WriteLine("\t下标\t学号\t姓名");

            i = 0;
            foreach (Stud s in myset)
            {
                Console.WriteLine("\t{0}\t{1}\t{2}", i, s.sno, s.sname);
                i++;
            }

            Console.WriteLine("容量：{0}", myset.Capacity);
            Console.WriteLine("容量：{0}", myset.Count);
        }
    }
}
