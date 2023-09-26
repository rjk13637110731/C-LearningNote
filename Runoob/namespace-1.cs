using System;
using first_space;

namespace first_space
{
    class namespace_c1
    {
        public void func()
        {
            Console.WriteLine("Inside first_space");
        }
    }
}

namespace second_space
{
    class namespace_c1
    {
        public void func()
        {
            Console.WriteLine("Inside second_space");
        }
    }
}

class TestClass
{
    public static void Main(string[] args)
    {
        first_space.namespace_c1 fc = new namespace_c1();
        second_space.namespace_c1 sc = new second_space.namespace_c1();
        fc.func();
        sc.func();
    }
}
