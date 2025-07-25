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
            this.Year = year;
            this.Make = make;
            this.Model = model;
            this.EngineNoise = engineNoise;
            this.HonkNoise = honkNoise;
            this.IsDriveable = isDriveable;

            CarLot.numberOfCars++;
            Console.WriteLine($"Current number of cars is {CarLot.numberOfCars}.");
        }

        public void MakeEngineNoise(string noise)
        { 
            Console.WriteLine("The " + this.Model + "'s engine is running: " + noise);
        }
        public void MakeHonkNoise(string noise)
        {
            Console.WriteLine("The " + this.Model + " honks: " + noise);
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
    }
}
