using System;

namespace car_primer2
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
            Engine myEngine = new Engine(2.5, 180);
            Car myCar = new Car("FlyCar", "Mark1", myEngine);
            Console.WriteLine(myCar.engine.volume);
            Console.WriteLine(myEngine.volume);

        }
    }
}
