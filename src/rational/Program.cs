using System;

namespace rational
{
    /// <summary>
    /// Gives the ability to use rational numbers, represented
    /// by a numerator and a denumerator, different from zero.
    /// <summary>
    class Rational
    {
        private int _num;
        private int _den;

        public double Dec => (double)this._num / this._den;

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
            if (den == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(den));
            }
            this._num = num;
            this._den = den;
        }

        /// <summary>
        /// Instanciates a class to the same as another instance of the class
        /// </summary>
        /// <param name="r">A rational that is being copied</param>
        public Rational(Rational r)
        {
            this._num = r._num;
            this._den = r._den;
        }

        /// <summary>
        /// Parses a string of the type int/int to a rational
        /// </summary>
        /// <param name="s">The string that is being parsed</param>
        /// <returns>The parsed Rational</returns>
        public static Rational Parse(string s)
        {
            string[] str = s.Split('/');
            return new Rational(int.Parse(str[0]), int.Parse(str[1]));
        }

        /// <summary>
        /// Tries to parse a string to rational.
        /// </summary>
        /// <param name="s">String that is parsed</param>
        /// <param name="r">The rational that is outed</param>
        /// <returns>true if is parsed successfully and false if it wasn't</returns>
        public static bool TryParse(string s, out Rational r)
        {
            string[] str = s.Split('/');
            if (str.Length != 2)
            {
                r = new Rational(0, 1);
                return false;
            }
            if (!int.TryParse(str[0], out int _))
            {
                r = new Rational(0, 1);
                return false;
            }
            if (!int.TryParse(str[1], out int _))
            {
                r = new Rational(0, 1);
                return false;
            }
            r = new Rational(int.Parse(str[0]), int.Parse(str[1]));
            return true;
        }

        public static Rational operator +(Rational r) => r;
        public static Rational operator -(Rational r) => new Rational(-r._num, r._den);

        /// <summary>
        /// Adds two rational numbers
        /// </summary>
        /// <param name="r1">First rational number</param>
        /// <param name="r2">Second rational number</param>
        /// <returns>A rational number that is the sum of r1 and r2</returns>
        public static Rational operator +(Rational r1, Rational r2)
            => new Rational(r1._num * r2._den + r2._num * r1._den, r1._den * r2._den);

        /// <summary>
        /// Subtracts two rational numbers
        /// </summary>
        /// <param name="r1">First rational number</param>
        /// <param name="r2">Second rational number</param>
        /// <returns>A rational number that is the difference of r1 and r2</returns>
        public static Rational operator -(Rational r1, Rational r2)
            => new Rational(r1._num * r2._den - r2._num * r1._den, r1._den * r2._den);

        /// <summary>
        /// Subtracts two rational numbers
        /// </summary>
        /// <param name="r1">First rational number</param>
        /// <param name="r2">Second rational number</param>
        /// <returns>A rational number that is the difference of r1 and r2</returns>
        public static Rational operator *(Rational r1, Rational r2)
            => new Rational(r1._num * r2._num, r1._den * r2._den);

        /// <summary>
        /// Subtracts two rational numbers
        /// </summary>
        /// <param name="r1">First rational number</param>
        /// <param name="r2">Second rational number</param>
        /// <returns>A rational number that is the difference of r1 and r2</returns>
        public static Rational operator /(Rational r1, Rational r2)
            => new Rational(r1._num * r2._den, r1._den * r2._num);

        /// <summary>
        /// Subtracts two rational numbers
        /// </summary>
        /// <param name="r1">First rational number</param>
        /// <param name="r2">Second rational number</param>
        /// <returns>A rational number that is the difference of r1 and r2</returns>
        public static bool operator ==(Rational r1, Rational r2)
            => r1._num * r2._den == r2._num * r1._den;

        /// <summary>
        /// Subtracts two rational numbers
        /// </summary>
        /// <param name="r1">First rational number</param>
        /// <param name="r2">Second rational number</param>
        /// <returns>A rational number that is the difference of r1 and r2</returns>
        public static bool operator !=(Rational r1, Rational r2)
            => r1._num * r2._den != r2._num * r1._den;

        /// <summary>
        /// Subtracts two rational numbers
        /// </summary>
        /// <param name="r1">First rational number</param>
        /// <param name="r2">Second rational number</param>
        /// <returns>A rational number that is the difference of r1 and r2</returns>
        public static bool operator >=(Rational r1, Rational r2)
            => r1._num * r2._den >= r2._num * r1._den;

        /// <summary>
        /// Subtracts two rational numbers
        /// </summary>
        /// <param name="r1">First rational number</param>
        /// <param name="r2">Second rational number</param>
        /// <returns>A rational number that is the difference of r1 and r2</returns>
        public static bool operator <=(Rational r1, Rational r2)
            => r1._num * r2._den <= r2._num * r1._den;

        /// <summary>
        /// Subtracts two rational numbers
        /// </summary>
        /// <param name="r1">First rational number</param>
        /// <param name="r2">Second rational number</param>
        /// <returns>A rational number that is the difference of r1 and r2</returns>
        private void Simp()
        {
            int gcd = GCD(this._num, this._den);
            this._num /= gcd;
            this._den /= gcd;
        }

        /// <summary>
        /// Calculates the greated common divisor of two integers
        /// </summary>
        /// <param name="a">First integer</param>
        /// <param name="b">Second integer</param>
        /// <returns>Greatest common divisor</returns>
        private int GCD(int a, int b)
        {
            if (b != 0)
                return this.GCD(b, a % b);
            return a;
        }

        /// <summary>
        /// Subtracts two rational numbers
        /// </summary>
        /// <param name="r1">First rational number</param>
        /// <param name="r2">Second rational number</param>
        /// <returns>A rational number that is the difference of r1 and r2</returns>
        public override string ToString()
        {
            this.Simp();
            return $"{_num} / {_den}";
            // return _num == 0 || _num == 1 ? $"{_num}" : $"{_num} / {_den}";
        }

        public override bool Equals(object o) => true;

        public override int GetHashCode() => 0;

        /// <summary>
        /// Subtracts two rational numbers
        /// </summary>
        /// <param name="r1">First rational number</param>
        /// <param name="r2">Second rational number</param>
        /// <returns>A rational number that is the difference of r1 and r2</returns>
        public double ToDouble() => (double)_num / _den;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rational.TryParse(Console.ReadLine(), out Rational r1));
            Console.WriteLine(r1);
            Console.WriteLine(Rational.TryParse(Console.ReadLine(), out Rational r2));
            Console.WriteLine(r2);


            // Rational r3 = new Rational(2, 5);
            // Rational r4 = new Rational(3, 4);
            Console.WriteLine((r1 + r2));
            Console.WriteLine((r1 - r2));
            Console.WriteLine((r1 * r2));
            Console.WriteLine((r1 / r2));
        }
    }
}
