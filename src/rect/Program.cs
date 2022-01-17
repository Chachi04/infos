using System;

namespace rect
{
    class Rectangle
    {
        protected int a, b;
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public Rectangle(int a)
        {
            this.a = a;
        }
        public virtual double Area()
        {
            return a * b;
        }
    }
    class Square : Rectangle
    {
        public Square(int a) : base(a) { }
        public override double Area()
        {
            return a * a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4, 5);
            Console.WriteLine(r.Area());
            Square s = new Square(4);
            Console.WriteLine(s.Area());
        }
    }
}
