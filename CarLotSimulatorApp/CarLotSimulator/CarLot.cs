using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot()
        {
        }
        public static void AddCar()
        {
            numberOfCars++;
            Console.WriteLine($"\n{numberOfCars} car added to the lot.\n");
        }
        public List<Car> cars = new List<Car>();

        //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
        //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        public static int numberOfCars;


    }
}
