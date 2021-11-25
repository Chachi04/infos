using System;

namespace primer4._2
{
    public class Engine
    {
        public double volume;
        public int power;

        public Engine(double engineVolume, int enginePower)
        {
            engineVolume *= 100;
            this.volume = engineVolume;
            this.power = enginePower;
        }
    }
    public class Car
    {
        public string brand;
        public string model;
        public Engine engine;

        public Car(string carBrand, string carModel, Engine carEngine)
        {
            this.brand = carBrand;
            this.model = carModel;
            this.engine = carEngine;
            this.engine.power = 110;
        }

        public void changeRef(ref Engine changeEngine)
        {
            Console.Write("Enter my new engine volume: ");
            double volume = double.Parse(Console.ReadLine());
            Console.Write("Enter my new engine power: ");
            int power = int.Parse(Console.ReadLine());
            Engine newEngine = new Engine(volume, power);
            changeEngine = newEngine;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter my old engine volume: ");
            double volume = double.Parse(Console.ReadLine());
            Console.Write("Enter my old engine power: ");
            int power = int.Parse(Console.ReadLine());

            Engine myEngine = new Engine(volume, power);
            Car myCar = new Car("FlyCar", "Mark1", myEngine);
            myCar.changeRef(ref myEngine);
            Console.WriteLine("myEngine.power = " + myEngine.power);
        }
    }
}
