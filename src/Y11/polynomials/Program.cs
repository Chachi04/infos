using System;

namespace polynomials
{
    public class Polynome
    {
        public double[] coefficients { get; set; }
        public int degree { get; set; }
        public Polynome() { }
        public Polynome(double[] coefficients)
        {
            this.coefficients = coefficients;
            this.degree = coefficients.Length - 1;
        }
        public static Polynome operator +(Polynome p1, Polynome p2)
        {
            int n = Math.Max(p1.degree, p2.degree);
            double[] newCoefficients = new double[n + 1];
            Array.Reverse(p1.coefficients);
            Array.Reverse(p2.coefficients);
            if (p1.degree == p2.degree)
            {
                for (int i = 0; i <= n; i++)
                {
                    newCoefficients[i] = p1.coefficients[i] + p2.coefficients[i];
                }

            }
            else if (p1.degree > p2.degree)
            {
                for (int i = 0; i <= p2.degree; i++)
                {
                    newCoefficients[i] = p1.coefficients[i] + p2.coefficients[i];
                }
                for (int i = p2.degree + 1; i <= n; i++)
                {
                    newCoefficients[i] = p1.coefficients[i];
                }

            }
            else
            {
                for (int i = 0; i <= p1.degree; i++)
                {
                    newCoefficients[i] = p1.coefficients[i] + p2.coefficients[i];
                }
                for (int i = p1.degree + 1; i <= n; i++)
                {
                    newCoefficients[i] = p2.coefficients[i];
                }
            }
            Array.Reverse(newCoefficients);
            return new Polynome(newCoefficients);
        }
        public static Polynome operator -(Polynome p1, Polynome p2)
        {
            int n = Math.Max(p1.degree, p2.degree);
            double[] newCoefficients = new double[n + 1];
            Array.Reverse(p1.coefficients);
            Array.Reverse(p2.coefficients);
            if (p1.degree == p2.degree)
            {
                for (int i = 0; i <= n; i++)
                {
                    newCoefficients[i] = p1.coefficients[i] - p2.coefficients[i];
                }

            }
            else if (p1.degree > p2.degree)
            {
                for (int i = 0; i <= p2.degree; i++)
                {
                    newCoefficients[i] = p1.coefficients[i] - p2.coefficients[i];
                }
                for (int i = p2.degree + 1; i <= n; i++)
                {
                    newCoefficients[i] = p1.coefficients[i];
                }

            }
            else
            {
                for (int i = 0; i <= p1.degree; i++)
                {
                    newCoefficients[i] = p1.coefficients[i] - p2.coefficients[i];
                }
                for (int i = p1.degree + 1; i <= n; i++)
                {
                    newCoefficients[i] = p2.coefficients[i];
                }
            }
            Array.Reverse(newCoefficients);
            return new Polynome(newCoefficients);
        }
        public static Polynome operator *(Polynome p1, Polynome p2)
        {
            double[] newCoefficients = new double[p1.degree + p2.degree + 1];
            for (int i = 0; i <= p1.degree; i++)
            {
                for (int j = 0; j <= p2.degree; j++)
                {
                    newCoefficients[i + j] += p1.coefficients[i] * p2.coefficients[j];
                }
            }
            return new Polynome(newCoefficients);
        }
        public void Print()
        {
            for (int i = 0; i <= this.degree; i++)
            {
                Console.Write(this.coefficients[i]);
                if (i != this.degree)
                {
                    Console.Write("x^" + (this.degree - i) + " ");
                    if (this.coefficients[i + 1] >= 0)
                        Console.Write("+ ");
                }

            }
            Console.WriteLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Polynome p1 = new Polynome(new double[] { 2, 3 });
            Polynome p2 = new Polynome(new double[] { -1, -2, 3 });
            Polynome p3 = p1 + p2;
            Polynome p4 = p1 - p2;
            Polynome p5 = p1 * p2;
            p3.Print();
            p4.Print();
            p5.Print();
        }
    }
}
