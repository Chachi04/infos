using System;


namespace template
{
    interface ITriangle
    {
        double Perimeter();
        double Area();
    }

    class Triangle : ITriangle
    {
        public double a;
        public double b;
        public double c;
        public double alpha;

        public Triangle(double a, double b, double alpha)
        {
            this.a = a;
            this.b = b;
            this.alpha = alpha*Math.PI/180;
            this.c = Math.Sqrt(Math.Pow(this.a, 2) + Math.Pow(this.b, 2) - 2 * a * b * Math.Cos(this.alpha));
        }

        public double Perimeter() => this.a + this.b + this.c;
        

        public double Area() => a * b * Math.Sin(alpha) / 2;
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle(3, 4, 90);
            Console.WriteLine(tr.Perimeter());
            Console.WriteLine(tr.Area());
        }
    }
}
