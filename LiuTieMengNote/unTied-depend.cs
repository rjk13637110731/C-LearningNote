using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new PhoneUser(new NokiaPhone());
            user.UsePhone();
            
            var user1 = new PhoneUser(new EricssonPhone());
            user1.UsePhone();
        }
    }

    class PhoneUser
    {
        // 接口类型的属性
        private IPhone _phone;

        public PhoneUser(IPhone phone)
        {
            _phone = phone;
        }

        public void UsePhone()
        {
            _phone.Dail();
            _phone.PickUp();
            _phone.Send();
            _phone.Recive();
        }
    }

    interface IPhone
    {
        void Dail();
        void PickUp();
        void Send();
        void Recive();
    }

    class NokiaPhone : IPhone // 点击这一行，Alt+Enter快速实现抽象方法
    {
        public void Dail()
        {
            Console.WriteLine("Nokia calling...");
        }

        public void PickUp()
        {
            Console.WriteLine("Hello!This is Tim!");
        }

        public void Send()
        {
            Console.WriteLine("Hello!");
        }

        public void Recive()
        {
            Console.WriteLine("Nokia message ring...");
        }
    }

    class EricssonPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Ericsson calling...");
        }

        public void PickUp()
        {
            Console.WriteLine("Hi!This is Tim!");
        }

        public void Send()
        {
            Console.WriteLine("Good evening!");
        }

        public void Recive()
        {
            Console.WriteLine("Ericsson message ring...");
        }
    }
}
