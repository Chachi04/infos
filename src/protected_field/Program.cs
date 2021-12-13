using System;

namespace protected_field
{
    class A
    {
        public int x = 100;
        protected int y = 200;
        private int z = 300;
    }
    class B : A
    {
        static void Main()
        {
            A a = new A();
            B b = new B();
            Console.WriteLine("Hello");
            // a.x = 1; a.y = 2; a.z = 3;
            // b.x = 1; b.y = 2; b.z = 3;
        }
    }
    class Program
    {
    }
}
