using System;

namespace triangle_overload
{
    class Triangle
    {
        public double Area(int a, int b, int c)
        {
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public double Area(int a, int b, double angle)
        {
            return a * b * Math.Sin(angle) / 2.0;
        }
        public double Area(int a, int h)
        {
            return a * h / 2.0;
        }
        public double Area(int a, int b, int c, int R)
        {
            return a * b * c / (double)(4 * R);
        }
        public double Area(int a, int b, int c, double r)
        {
            double p = (a + b + c) / 2.0;
            return p * r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            Console.WriteLine(t.Area(3, 4, 5));
            Console.WriteLine(t.Area(3, 4, Math.PI / 2));
            Console.WriteLine(t.Area(5, 2));
            Console.WriteLine(t.Area(6, 8, 10, 5));
            Console.WriteLine(t.Area(3, 4, 5, 1.0));
        }
    }
}
