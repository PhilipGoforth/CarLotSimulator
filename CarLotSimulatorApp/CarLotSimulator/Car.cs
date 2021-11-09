using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }
        public Car(int year, string make, string model, bool driveable)
        {
            CarLot.numberOfCars++;
            Year = year;
            Make = make;
            Model = model;
            IsDriveable = driveable;
        }
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        public int Year;
        public string Make;
        public string Model;
        public string EngineNoise;
        public string HonkNoise;
        public bool IsDriveable;

        public void MakeEngineNoise()
        {
            Console.WriteLine($"You start the {Model} and hear {EngineNoise}!");
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine($"You push the horn and hear {HonkNoise}!\n");
        }

    }
}
