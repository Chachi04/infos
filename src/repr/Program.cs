using System;

namespace repr
{
    class Represent
    {
        static public void repr(object obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
    class Rational
    {
        int num; int den;
        public Rational(int n, int d)
        {
            this.num = n;
            this.den = d;
        }
        public override string ToString()
        {
            return this.num.ToString() + "/" + this.den.ToString();
        }
        public Rational Add(Rational r)
        {
            Rational res = new Rational(0, 1);
            res.num = this.num * r.den + this.den * r.num;
            res.num = this.den * r.den;
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Rational r = new Rational(4, 7);
            Console.WriteLine(a);
            Console.WriteLine(r);
            // Represent.repr(a);
            // Represent.repr(r);
        }
    }
}
