using System;

namespace rational0._1
{
    /// <summary>
    /// Gives the ability to use rational numbers, represented
    /// by a numerator and a denumerator, different from zero.
    /// <summary>
    class Rational
    {
        public int num;
        public int den;

        /// <summary>
        /// Instanciates the class
        /// </summary>
        public Rational() { }

        /// <summary>
        /// Instanciates the class with given atributes
        /// </summary>
        /// <param name="num">Numberator</param>
        /// <param name="den">Denumerator</param>
        /// <exception cref="ArgumentException">Denominator cannot be zero</exception>
        public Rational(int num, int den)
        {
            this.num = num;
            this.den = den;
        }

        /// <summary>
        /// Instanciates a class to the same as another instance of the class
        /// </summary>
        /// <param name="r">A rational that is being copied</param>
        public Rational(Rational r)
        {
            this.num = r.num;
            this.den = r.den;
        }

        /// <summary>
        /// Adds a rational to this one
        /// </summary>
        /// <param name="r">The ratioanl that is being add</param>
        public void Add(Rational r)
        {
            this.num = this.num * r.den + r.num * this.den;
            this.den = this.den * r.den;
            this.Simp();
        }


        /// <summary>
        /// Subtracts two rational numbers
        /// </summary>
        /// <param name="r">The second rational</param>
        public void Sub(Rational r)
        {
            this.num = this.num * r.den - r.num * this.den;
            this.den = this.den * r.den;
            this.Simp();
        }

        /// <summary>
        /// Multiplies two rational numbers
        /// </summary>
        /// <param name="r">The second rational</param>
        public void Mult(Rational r)
        {
            this.num = this.num * r.num;
            this.den = this.den * r.den;
            this.Simp();
        }

        /// <summary>
        /// Devides two rational numbers
        /// </summary>
        /// <param name="r">The second rational</param>
        public void Dev(Rational r)
        {
            this.num = this.num * r.den;
            this.den = this.den * r.num;
            this.Simp();
        }

        /// <summary>
        /// Compares the second rational to the first.
        /// Returns 1 if the first is greater,
        /// Returns -1 if the second is greated,
        /// Returns 0 if they are the same.
        /// </summary>
        /// <param name="r">The second rational</param>
        /// <returns>1,-1 or 0</returns>
        public int Compare(Rational r)
        {
            if (this.num * r.den > r.num * this.den) return 1;
            if (this.num * r.den < r.num * this.den) return -1;
            return 0;
        }

        /// <summary>
        /// Print the rational in decimal form
        /// </summary>
        public void PrintDec()
        {
            Console.WriteLine(Math.Round((double)this.num / this.den, 2));
        }

        /// <summary>
        /// Print the rational in normal form
        /// </summary>
        public void Print()
        {
            if (this.den == 1 || this.num == 0)
                Console.WriteLine(this.num);
            else
                Console.WriteLine($"{this.num} / {this.den}");
        }

        /// <summary>
        /// Multiply two rational numbers
        /// </summary>
        /// <param name="r">The second rational</param>
        private void Simp()
        {
            int d = this.GCD(this.num, this.den);
            this.num /= d;
            this.den /= d;
        }

        /// <summary>
        /// Calculates the greated common divisor of two integers
        /// </summary>
        /// <param name="a">First integer</param>
        /// <param name="b">Second integer</param>
        /// <returns>Greatest common divisor</returns>
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
