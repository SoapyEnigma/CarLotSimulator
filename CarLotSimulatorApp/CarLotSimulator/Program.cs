using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            CarLot lot = new CarLot();

            Car corvette = new Car();
            corvette.Year = 1981;
            corvette.Make = "Chevrolet";
            corvette.Model = "Corvette";
            corvette.EngineNoise = "GRRR";
            corvette.HonkNoise = "HONK!";
            corvette.IsDriveable = false;

            lot.carLot.Add(corvette);

            Car mr2 = new Car()
            {
                Year = 2000, Make = "Toyota", Model = "MR2",
                EngineNoise = "BRRR", HonkNoise = "BEEP", IsDriveable = true,
            };

            lot.carLot.Add(mr2);

            Car bolide = new Car(2025, "Bugatti", "Bolide",
                "ROOOAR", "BEEP BEEP", true);

            lot.carLot.Add(bolide);

            corvette.MakeEngineNoise(corvette.EngineNoise);
            corvette.MakeHonkNoise(corvette.HonkNoise);

            mr2.MakeEngineNoise(mr2.EngineNoise);
            mr2.MakeHonkNoise(mr2.HonkNoise);

            bolide.MakeEngineNoise(bolide.EngineNoise);
            bolide.MakeHonkNoise(bolide.HonkNoise);

            foreach (Car car in lot.carLot)
                Console.WriteLine(car.Year.ToString() + " " + car.Make + " " + car.Model);

            Console.ReadLine();
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
