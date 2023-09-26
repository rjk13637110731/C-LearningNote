using System;

namespace Test
{
    interface IMyInterface
    {
        void MethodToImplement();
    }

    class InterfaceImplementer : IMyInterface
    {
        public static void Main(string[] args)
        {
            InterfaceImplementer iImp = new InterfaceImplementer();
            iImp.MethodToImplement();
        }

        public void MethodToImplement()
        {
            Console.WriteLine("MethodToImplement() called.");
        }
    }
}
