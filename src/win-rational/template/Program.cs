using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template
{
    class Rational
    {
        private int _num;
        private int _den;

        public double Dec => (double)this._num / this._den;

        public Rational() { }

        public Rational(int num, int den)
        {
            if (den == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(den));
            }
            this._num = num;
            this._den = den;
        }

        public Rational(Rational r)
        {
            this._num = r._num;
            this._den = r._den;
        }

        public static Rational Parse(string s)
        {
            string[] str = s.Split('/');
            return new Rational(int.Parse(str[0]), int.Parse(str[1]));
        }

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

        public static bool operator !=(Rational r1, Rational r2)
            => r1._num * r2._den != r2._num * r1._den;

        public static bool operator >=(Rational r1, Rational r2)
            => r1._num * r2._den >= r2._num * r1._den;

        public static bool operator <=(Rational r1, Rational r2)
            => r1._num * r2._den <= r2._num * r1._den;

        public override string ToString() => _num != 0 ? $"{_num} / {_den}" : "0";

        public override bool Equals(object o) => true;

        public override int GetHashCode() => 0;

        public double ToDouble() => (double)_num / _den;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rational.TryParse("2 / 5", out Rational r1));
            Console.WriteLine(r1);
            Console.WriteLine(Rational.TryParse("25", out Rational r2));
            Console.WriteLine(r2);


            Rational r3 = new Rational(2, 5);
            Rational r4 = new Rational(3, 4);
            Console.WriteLine((r1 + r2).ToDouble());
            Console.WriteLine((r1 - r2).ToDouble());
            Console.WriteLine((r1 * r2).ToDouble());
            Console.WriteLine((r1 / r2).ToDouble());
        }
    }
}
