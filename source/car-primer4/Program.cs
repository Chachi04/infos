using System;

namespace car_primer4
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
            Engine newEngine = new Engine(5, 600);
            changeEngine = newEngine;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Engine myEngine = new Engine(2, 180);
            Car myCar = new Car("FlyCar", "Mark1", myEngine);
            myCar.changeRef(ref myEngine);
            Console.WriteLine(myEngine.power);
        }
    }
}
