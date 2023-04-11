using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.

            var lot = new CarLot();
           

            //DONE - Create a seperate class file called Car
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //Using Dot Notation 

            var HenryCar = new Car();
            HenryCar.Make = "Audi";
            HenryCar.Model = "Q3";
            HenryCar.Year = 2018;
            HenryCar.EngineNoise = "vroom";
            HenryCar.HonkNoise = "beep";
            HenryCar.IsDrivable = true;

            lot.Cars.Add(HenryCar);

            //Object Initializer Syntax 

            var stevesCar = new Car()
            {
              Year = 2019,
              Make = "Tesla",
              Model = "Cyber Truck",
              EngineNoise = "...",
              HonkNoise = "brmp",
              IsDrivable = false
            };

            lot.Cars.Add(stevesCar);

            //Using the consructor to allow parameter value to be placed inside properties

            var brettsCar = new Car(2022,"Honda","Civic","vroom","vruuuga", true);

            lot.Cars.Add(brettsCar);

            //Call Methods
            HenryCar.MakeEngineNoise();
            stevesCar.MakeEngineNoise();
            brettsCar.MakeEngineNoise();

            //*************BONUS*************//

            // DONE-Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //DONE-Create a CarLot class
            //DONE-It should have at least one property: a List of cars
            
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (var car in lot.Cars) 
            {
                Console.WriteLine($"Year:{car.Year} Make:{car.Make} Model:{car.Model}");
            }
        } 
    }
}
