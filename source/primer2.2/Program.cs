using System;

namespace primer2._2
{
    public class Engine
    {
        public double volume;
        public int power;

        public Engine(double volume, int power)
        {
            this.volume = volume;
            this.power = power;
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
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the engine volume: ");
            double volume = double.Parse(Console.ReadLine());
            Console.Write("Enter the engine power: ");
            int power = int.Parse(Console.ReadLine());

            Engine myEngine = new Engine(volume, power);
            Car myCar = new Car("FlyCar", "Mark1", myEngine);
            Console.WriteLine("MyCar.engine.volume = " + myCar.engine.volume);
            Console.WriteLine("myEngine.volume = " + myEngine.volume);
            Console.WriteLine("MyCar.engine.power = " + myCar.engine.power);
            Console.WriteLine("myEngine.power = " + myEngine.power);

        }
    }
}
