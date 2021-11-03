using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car   DONE

            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            var myCarLot = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars
            Car myCar = new Car(1994, "Jeep", "Cherokee", true);
            myCar.EngineNoise = "Knocking";
            myCar.HonkNoise = "Beep!";
            myCar.MakeEngineNoise(myCar.EngineNoise);
            myCar.MakeHonkNoise(myCar.HonkNoise);

            myCarLot.cars.Add(myCar);

            var myOtherCar = new Car(2004, "Porsche", "Cayenne", true);
            myOtherCar.EngineNoise = "Whining";
            myOtherCar.HonkNoise = "Honk!";
            myOtherCar.MakeEngineNoise(myOtherCar.EngineNoise);
            myOtherCar.MakeHonkNoise(myOtherCar.HonkNoise);

            myCarLot.cars.Add(myOtherCar);

            Car myThirdCar = new Car(1932, "Ford", "Model T", true);
            myThirdCar.EngineNoise = "Meowing";
            myThirdCar.HonkNoise = "AOOOGA!";
            myThirdCar.MakeEngineNoise(myThirdCar.EngineNoise);
            myThirdCar.MakeHonkNoise(myThirdCar.HonkNoise);

            myCarLot.cars.Add(myThirdCar);
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine("Inventory of cars:\n");
            foreach(var Car in myCarLot.cars)
            {
                Console.WriteLine($"{Car.Year} {Car.Make} {Car.Model}\n");
            }

            
        }
    }
}
