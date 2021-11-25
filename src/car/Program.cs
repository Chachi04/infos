using System;

namespace car
{
    public class Car
    {
        public string brand;
        public string model;
        public int engineVolume;
        public int yearProd;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Console.Write("Въведете макра: ");
            myCar.brand = Console.ReadLine();

            Console.Write("Въведете модел: ");
            myCar.model = Console.ReadLine();

            Console.Write("Въведете обем на двигателя: ");
            myCar.engineVolume = int.Parse(Console.ReadLine());

            Console.Write("Въведете година на производство: ");
            myCar.yearProd = int.Parse(Console.ReadLine());

            double annualTax = 0.2 * myCar.engineVolume +
            (
                myCar.yearProd <= 2000 ? 70 :
                myCar.yearProd <= 2010 ? 60 : 50
            );

            Console.WriteLine($"Данък на {myCar.brand}, {myCar.model}");
            Console.WriteLine($"с обем на двигателя {myCar.engineVolume}");
            Console.WriteLine($"произведена през {myCar.yearProd} година");
            Console.WriteLine($"е {annualTax:c} година");
        }
    }
}
