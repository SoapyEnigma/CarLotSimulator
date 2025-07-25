using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
            Console.WriteLine($"Current number of cars is {CarLot.numberOfCars}.");
        }
        public Car(int year, string make, string model,
            string engineNoise, string honkNoise, bool isDriveable)
        {
            this.year = year;
            this.make = make;
            this.model = model;
            this.engineNoise = engineNoise;
            this.honkNoise = honkNoise;
            this.IsDriveable = isDriveable;

            CarLot.numberOfCars++;
            Console.WriteLine($"Current number of cars is {CarLot.numberOfCars}.");
        }

        public void MakeEngineNoise(string noise)
        { 
            Console.WriteLine("The " + this.model + "'s engine is running: " + noise);
        }
        public void MakeHonkNoise(string noise)
        {
            Console.WriteLine("The " + this.model + " honks: " + noise);
        }

        public int year;
        public string make;
        public string model;
        public string engineNoise;
        public string honkNoise;
        public bool IsDriveable;
    }
}
