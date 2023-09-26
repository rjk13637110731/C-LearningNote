using System;

namespace SomeNameSpace
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("In SomeNameSpace");
            Nested.NestedNameSpaceClass.SayHello();
        }
    }

    namespace Nested
    {
        public class NestedNameSpaceClass
        {
            public static void SayHello()
            {
                Console.WriteLine("In Nested!");
            }
        }
    }
}
