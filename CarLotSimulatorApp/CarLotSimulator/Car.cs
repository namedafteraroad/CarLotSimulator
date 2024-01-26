using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        //default constructor
        public Car()
        {
            CarLot.numberOfCars++;
        }

        //custom constructor
        public Car(string make, string model, int year, string engineNoise, string honkNoise, bool driveable)
        {
            CarLot.numberOfCars++;
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = driveable;

        }


        
        public string Make {  get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public int Year { get; set; }

        public bool IsDriveable { get; set; }


        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"{Model}, {engineNoise}");
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"{Model}, {honkNoise}");
        }



    }
}
//TODO

//Create a seperate class file called Car-DONE
//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable -DONE
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