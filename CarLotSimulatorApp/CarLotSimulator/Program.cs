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
            Car myCar = new Car();
            myCar.Year = 2020;
            myCar.Make = "Toyota";
            myCar.Model = "RAV4";

            Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model}");
            myCar.MakeEngineNoise();
            myCar.MakeHonkNoise();

            
            Car herCar = new Car();
            herCar.Year = 2021;
            herCar.Make = "Toyota";
            herCar.Model = "Camry";
            Console.WriteLine($"Her car is a {herCar.Year} {herCar.Make} {herCar.Model}");
            herCar.MakeEngineNoise();
            herCar.MakeHonkNoise();

            Car hisCar = new Car();
            hisCar.Year = 1978;
            hisCar.Make = "Ford";
            hisCar.Model = "Pinto";
            Console.WriteLine($"His car is a {hisCar.Year} {hisCar.Make} {hisCar.Model}");
            hisCar.MakeEngineNoise();
            hisCar.MakeHonkNoise();
            
            


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
