using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITriangle
{
    interface ITriangle
    {
        double Perimeter();
        double Area();
    }
    class Triangle : ITriangle
    {
        private double a,b,c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double Perimeter()
        {
            return a + b + c;
        }
        public double Area()
        {
            double p = this.Perimeter() / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle(3, 4, 5);
            Console.WriteLine(t.Perimeter());
            Console.WriteLine(t.Area());
        }
    }
}
