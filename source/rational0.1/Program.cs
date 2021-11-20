using System;

namespace rational0._1
{
    class Rational
    {
        public int num;
        public int den;

        public Rational()
        {
            this.num = 0;
            this.den = 1;
        }

        public Rational(int num, int den)
        {
            this.num = num;
            this.den = den;
        }

        public Rational(Rational r)
        {
            this.num = r.num;
            this.den = r.den;
        }

        public void Add(Rational r)
        {
            this.num = this.num * r.den + r.num * this.den;
            this.den = this.den * r.den;
            this.Simp();
        }

        public void Sub(Rational r)
        {
            this.num = this.num * r.den - r.num * this.den;
            this.den = this.den * r.den;
            this.Simp();
        }

        public void Mult(Rational r)
        {
            this.num = this.num * r.num;
            this.den = this.den * r.den;
            this.Simp();
        }

        public void Dev(Rational r)
        {
            this.num = this.num * r.den;
            this.den = this.den * r.num;
            this.Simp();
        }

        public int Compare(Rational r)
        {
            if (this.num * r.den > r.num * this.den) return 1;
            if (this.num * r.den < r.num * this.den) return -1;
            return 0;
        }

        public void PrintDec()
        {
            Console.WriteLine(Math.Round((double)this.num / this.den, 2));
        }

        public void Print()
        {
            if (this.den == 1 || this.num == 0)
                Console.WriteLine(this.num);
            else
                Console.WriteLine($"{this.num} / {this.den}");
        }

        private void Simp()
        {
            int d = this.GCD(this.num, this.den);
            this.num /= d;
            this.den /= d;
        }

        private int GCD(int a, int b) => b != 0 ? GCD(b, a % b) : a;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(),
                     r2 = new Rational();


            Console.Write("Enter the numerator for the first number: ");
            r1.num = int.Parse(Console.ReadLine());
            Console.Write("Enter the denumerator for the first number: ");
            r1.den = int.Parse(Console.ReadLine());

            Console.Write("Enter the numerator for the second number: ");
            r2.num = int.Parse(Console.ReadLine());
            Console.Write("Enter the denumerator for the second number: ");
            r2.den = int.Parse(Console.ReadLine());

            Rational r3 = new Rational(r1),
                     r4 = new Rational(r1),
                     r5 = new Rational(r1),
                     r6 = new Rational(r1);

            r3.Add(r2);
            Console.Write("Sum: ");
            r3.Print();
            r3.PrintDec();

            r4.Sub(r2);
            Console.Write("Sub: ");
            r4.Print();
            r4.PrintDec();

            r5.Mult(r2);
            Console.Write("Mul: ");
            r5.Print();
            r5.PrintDec();

            r6.Dev(r2);
            Console.Write("Dev: ");
            r6.Print();
            r6.PrintDec();

        }
    }
}
