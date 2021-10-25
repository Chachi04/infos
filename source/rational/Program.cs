using System;

namespace rational
{
    class Rational
    {
        private int _num;
        private int _den;

        public Rational(int num, int den)
        {
            if (den == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(den));
            }
            this._num = num;
            this._den = den;
        }

        public double dec => (double)this._num / this._den;

        public static Rational operator +(Rational r) => r;
        public static Rational operator -(Rational r) => new Rational(-r._num, r._den);

        public static Rational operator +(Rational r1, Rational r2)
            => new Rational(r1._num * r2._den + r2._num * r1._den, r1._den * r2._den);

        public static Rational operator -(Rational r1, Rational r2)
            => new Rational(r1._num * r2._den - r2._num * r1._den, r1._den * r2._den);

        public static Rational operator *(Rational r1, Rational r2)
            => new Rational(r1._num * r2._num, r1._den * r2._den);

        public static Rational operator /(Rational r1, Rational r2)
            => new Rational(r1._num * r2._den, r1._den * r2._num);

        public static bool operator ==(Rational r1, Rational r2)
            => r1._num * r2._den == r2._num * r1._den;

        public override bool Equals(object o)
        {
            return true;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public static bool operator !=(Rational r1, Rational r2)
            => r1._num * r2._den != r2._num * r1._den;

        public static bool operator >=(Rational r1, Rational r2)
            => r1._num * r2._den >= r2._num * r1._den;

        public static bool operator <=(Rational r1, Rational r2)
            => r1._num * r2._den <= r2._num * r1._den;

        public override string ToString() => $"{_num} / {_den}";

        public double ToDouble()
        {
            return (double)_num / _den;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(2, 5);
            Rational r2 = new Rational(3, 4);
            Console.WriteLine((r1 + r2).ToDouble());
            Console.WriteLine((r1 - r2).ToDouble());
            Console.WriteLine((r1 * r2).ToDouble());
            Console.WriteLine((r1 / r2).ToDouble());
        }
    }
}
