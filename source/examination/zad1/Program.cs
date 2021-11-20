using System;

namespace zad1
{
    class Pravoagalnik
    {
        private double a;
        private double b;
        private double obikolka;

        public double A
        {
            set
            {
                if (value > 0)
                    this.a = value;
                else
                {
                    Console.WriteLine("Страната трябва да е положително число.\nСтрана 'а' ще се смята за 20см");
                    this.a = 20;
                }
            }
            get { return this.a; }
        }

        public double B
        {
            set
            {
                if (value > 0)
                    this.b = value;
                else
                {
                    Console.WriteLine("Страната трябва да е положително число.\nСтрана 'b' ще се смята за 20см");
                    this.b = 20;
                }
            }
            get { return this.b; }
        }

        public Pravoagalnik()
        {
            this.a = 20;
            this.b = 20;
        }

        public Pravoagalnik(Pravoagalnik r)
        {
            this.a = r.a;
            this.b = r.b;
        }

        public void CalcObikolka()
        {
            this.obikolka = 2 * (this.a + this.b);
        }

        public void Print()
        {
            Console.WriteLine("Размери на провоъгълника:");
            Console.WriteLine($"Страна 1: {this.a} cm");
            Console.WriteLine($"Страна 2: {this.b} cm");
            Console.WriteLine($"Обиколка: {this.obikolka} cm");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Pravoagalnik rect = new Pravoagalnik();
            Console.Write("Въведи страна 1: ");
            rect.A = int.Parse(Console.ReadLine());
            Console.Write("Въведи страна 2: ");
            rect.B = int.Parse(Console.ReadLine());

            Pravoagalnik rect2 = new Pravoagalnik(rect);

            rect.CalcObikolka();
            rect2.CalcObikolka();

            rect.Print();
            rect2.Print();

        }
    }
}
