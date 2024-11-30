using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ctrl + M + O 把所有的方法体全部折叠

namespace NumNet
{
    /// <summary>
    /// 向量
    /// </summary>
    public class Vector
    {
        #region 保护成员
        /// <summary>
        /// 存储向量数据的数组
        /// </summary>
        protected double[] _data;
        #endregion

        #region 公有属性
        /// <summary>
        /// 向量元素个数
        /// </summary>
        public int Length => _data.Length;
        #endregion

        #region 构造方法
        /// <summary>
        /// 构造一个空向量
        /// </summary>
        public Vector()
        {
            _data = new double[0];
        }

        /// <summary>
        /// 构造一个元素个数为Length的向量，默认元素为0；
        /// 当fillOne为true时，元素均为1
        /// </summary>
        /// <param name="length"></param>
        /// <param name="fillOne"></param>
        public Vector(int length, bool fillOne = false)
        {
            _data = new double[length];
            if (fillOne)
            {
                for (int i = 0; i < length; i++)
                {
                    _data[i] = 1;
                }
            }
        }

        /// <summary>
        /// 根据一系列元素构造向量
        /// </summary>
        /// <param name="values"></param>
        public Vector(params double[] values)
        {
            _data = new double[values.Length];
            Array.Copy(values, _data, values.Length);
        }
        #endregion

        #region 公共方法
        /// <summary>
        /// 构造一个索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public double this[int index]
        {
            get => _data[index];
            set => _data[index] = value;
        }

        /// <summary>
        /// 返回当前向量的拷贝
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        public static Vector operator +(Vector v1)
        {
            return v1.Copy();
        }

        /// <summary>
        /// 返回当前向量的相反向量
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        public static Vector operator -(Vector v1)
        {
            Vector v = new Vector(v1.Length);
            for (int i = 0; i < v1.Length; i++)
            {
                v[i] = -v1[i];
            }
            return v;
        }

        /// <summary>
        /// 向量相加
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Vector operator +(Vector v1, Vector v2)
        {
            if (v1.Length != v2.Length)
            {
                throw new Exception("两向量元素个数不相等，不能相加！");
            }
            Vector v = new Vector(v1.Length);
            for (int i = 0; i < v1.Length; i++)
            {
                v[i] = v1[i] + v2[i];
            }
            return v;
        }

        /// <summary>
        /// 向量相减
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Vector operator -(Vector v1, Vector v2)
        {
            if (v1.Length != v2.Length)
            {
                throw new Exception("两向量元素个数不相等，不能相减！");
            }
            Vector v = new Vector(v1.Length);
            for (int i = 0; i < v1.Length; i++)
            {
                v[i] = v1[i] - v2[i];
            }
            return v;
        }

        /// <summary>
        /// 向量点成乘
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static double operator *(Vector v1, Vector v2)
        {
            if (v1.Length != v2.Length)
            {
                throw new Exception("两向量元素个数不相等，不能点乘！");
            }
            double sum = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                sum += v1[i] * v2[i];
            }
            return sum;
        }

        /// <summary>
        /// 数乘向量
        /// </summary>
        /// <param name="scale"></param>
        /// <param name="v1"></param>
        /// <returns></returns>
        public static Vector operator *(double scale, Vector v1)
        {
            Vector v = new Vector(v1.Length);
            for (int i = 0; i < v1.Length; i++)
            {
                v[i] = v1[i] * scale;
            }
            return v;
        }

        /// <summary>
        /// 向量乘数
        /// </summary>
        /// <param name="scale"></param>
        /// <param name="v1"></param>
        /// <returns></returns>
        public static Vector operator *(Vector v1, double scale)
        {
            return scale * v1;
        }

        /// <summary>
        /// 向量除数
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="scale"></param>
        /// <returns></returns>
        public static Vector operator /(Vector v1, double scale)
        {
            return 1 / scale * v1;
        }

        /// <summary>
        /// 向量按元素相乘
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Vector Mutiply(Vector v1)
        {
            if (v1.Length != this.Length)
            {
                throw new Exception("两向量元素个数不相等，不能按元素相乘！");
            }
            Vector v = new Vector(v1.Length);
            for (int i = 0; i < v1.Length; i++)
            {
                v[i] = this[i] * v1[i];
            }
            return v;
        }

        /// <summary>
        /// 向量按元素相除
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Vector Divide(Vector v1)
        {
            if (v1.Length != this.Length)
            {
                throw new Exception("两向量元素个数不相等，不能按元素相除！");
            }
            Vector v = new Vector(v1.Length);
            for (int i = 0; i < v1.Length; i++)
            {
                v[i] = this[i] / v1[i];
            }
            return v;
        }

        /// <summary>
        /// 判断向量是否为零向量
        /// </summary>
        /// <returns></returns>
        public bool IsZero() 
        {
            for (int i = 0; i < Length; i++) 
            {
                if (this[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 判断向量是否相等
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        public bool Equals(Vector v1)
        {
            if (this.Length != v1.Length)
            {
                return false;
            }

            for (int i = 0; i < Length; i++) 
            {
                if (this[i] != v1[i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 元素个数为end-begin的字向量，包括索引为begin的元素，但不包括end的元素
        /// </summary>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public Vector SubVector(int begin,int end) 
        { 
            Vector v = new Vector(end - begin);
            Array.Copy(_data, begin, v._data, 0, end - begin);
            return v;
        }

        /// <summary>
        /// 拼接向量，当前向量在前，v1在后
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        public Vector Concat(Vector v1) 
        {
            Vector v = new Vector(this.Length + v1.Length);

            Array.Copy(_data, v._data, Length);
            Array.Copy(v1._data, 0, v._data, Length, v1.Length);
            return v;
        }

        /// <summary>
        /// 向量的拷贝
        /// </summary>
        /// <returns></returns>
        public Vector Copy()
        {
            return new Vector(_data);
        }

        /// <summary>
        /// 重写ToString方法
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "[" + string.Join(", ", _data) + "]";
        }
        #endregion
    }
}
