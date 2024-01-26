using System;
using System.Net.WebSockets;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            // use the 3 cars in the Main() (from the previous exercise) and then each time you create a car do a Console.WriteLine() printing the current number of cars in the car lot.
            CarLot myCarLot = new CarLot();

            
            
            
            
            
            //Three different ways, dot, ois, 
            //dot
            Car Bronco = new Car();
            Bronco.Make = "Ford";
            Bronco.Model = "Bronco";
            Bronco.Year = 1966;
            Bronco.MakeEngineNoise("Vroom");
            Bronco.MakeHonkNoise("Beep");
            Bronco.IsDriveable = true;

            Console.WriteLine($"{CarLot.numberOfCars} cars in the lot");

            //OIS
            Car Ram = new Car() { Make = "Dodge", Model = "Ram", Year = 2024, EngineNoise = "BRRRRBBRBR", HonkNoise = "BROUMP", IsDriveable = true  };

            Console.WriteLine($"{CarLot.numberOfCars} cars in the lot");

            //custom
            Car Soul = new Car("Kia", "Soul", 2023, "vrr", "bep", false);

            Console.WriteLine($"{CarLot.numberOfCars} cars in the lot");


            myCarLot.ListOfCars.Add(Bronco);
            myCarLot.ListOfCars.Add(Ram);
            myCarLot.ListOfCars.Add(Soul);



           // foreach(var car in myCarLot.ListOfCars)
            //{
            //    Console.WriteLine($"{car.Make}");
            //    Console.WriteLine($"{car.Model}");
            //    Console.WriteLine($"{car.Year}");
            //    Console.WriteLine($"{car.EngineNoise}");
            //    Console.WriteLine($"{car.HonkNoise}");
            //    Console.WriteLine($"{car.IsDriveable}");
           //     
           // }






            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

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
