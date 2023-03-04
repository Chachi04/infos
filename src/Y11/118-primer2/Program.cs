using System;

namespace _118_primer2
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
        public Rational Add(Rational r)
        {
            this.num = this.num * r.den + r.num * this.den;
            this.den = this.den * r.den;
            this.Simp();
            return this;
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

        public override string ToString()
        {
            return this.num + "/" + this.den;
        }
    }
    class Represent
    {
        public void repr(object obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            object a = new Rational(2, 3);
            Rational b = (Rational)a;
            Rational res = b.Add(b);
            Represent r = new Represent();
            r.repr(res);
        }
    }
}
