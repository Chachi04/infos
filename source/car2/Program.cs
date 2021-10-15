using System;

namespace car2
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

            double annualTax = 0.2 * myCar.EngineVolume +
            (
                myCar.YearProd <= 2000 ? 70 :
                myCar.YearProd <= 2010 ? 60 : 50
            );

            Console.WriteLine($"Данък на {myCar.Brand}, {myCar.Model}");
            Console.WriteLine($"с обем на двигателя {myCar.EngineVolume}");
            Console.WriteLine($"произведена през {myCar.YearProd} година");
            Console.WriteLine($"е {annualTax:c} година");
        }
    }
}
