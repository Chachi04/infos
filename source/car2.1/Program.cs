using System;

namespace car2._1
{
    public class Car
    {
        private string brand;
        private string model;
        private int engineVolume;
        private int yearProd;

        public string Brand
        {
            set { this.brand = value; }
            get { return this.brand; }
        }
        public string Model
        {
            set { this.model = value; }
            get { return this.model; }
        }
        public int EngineVolume
        {
            set { this.engineVolume = value; }
            get { return this.engineVolume; }
        }
        public int YearProd
        {
            set { this.yearProd = value; }
            get { return this.yearProd; }
        }

        public double annualTax => 0.2 * this.EngineVolume +
        (
            this.YearProd <= 2000 ? 70 :
            this.YearProd <= 2010 ? 60 : 50
        );

        public void print()
        {
            Console.WriteLine($"Данък на {this.Brand}, {this.Model}");
            Console.WriteLine($"с обем на двигателя {this.EngineVolume}");
            Console.WriteLine($"произведена през {this.YearProd} година");
            Console.WriteLine($"е {Math.Round(this.annualTax)} година");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Console.Write("Въведете макра: ");
            myCar.Brand = Console.ReadLine();

            Console.Write("Въведете модел: ");
            myCar.Model = Console.ReadLine();

            Console.Write("Въведете обем на двигателя: ");
            myCar.EngineVolume = int.Parse(Console.ReadLine());

            Console.Write("Въведете година на производство: ");
            myCar.YearProd = int.Parse(Console.ReadLine());

            myCar.print();
        }
    }
}
