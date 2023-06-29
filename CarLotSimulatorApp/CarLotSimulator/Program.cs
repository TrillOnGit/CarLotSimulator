using System;
using System.Collections.Generic;
using System.Linq;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            CarLot myDriveway = new CarLot(cars);
            //TODO

            //Now that the Car class is created we can instantiate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //Uncomfortable parameters
            Car firestoneColumbus = new Car();
            firestoneColumbus.Make = "Buggy";
            firestoneColumbus.Model = "Model 5002";
            firestoneColumbus.Year = 1909;
            firestoneColumbus.IsDriveable = false;
            firestoneColumbus.EngineNoise = "Chugga chugga";
            firestoneColumbus.HonkNoise = "Kwerr";

            firestoneColumbus.MakeEngineNoise(firestoneColumbus.EngineNoise);
            firestoneColumbus.MakeHonkNoise(firestoneColumbus.HonkNoise);

            cars.Add(firestoneColumbus);
            
            //Comfy parameters
            Car bus = new Car()
            {
                Make = "Bus Mart",
                Model = "Bus 3",
                Year = 2009,
                IsDriveable = true,
                EngineNoise = "Bubba bubba",
                HonkNoise = "Bromp Bromp"
            };
            
            bus.MakeEngineNoise(bus.EngineNoise);
            bus.MakeHonkNoise(bus.HonkNoise);
            
            cars.Add(bus);
            
            //Constructor instantiate
            
            Car jeep = new Car(2025, "Mazda", "Model Epsilon", "rumble rumble", "Beep beep", false);

            jeep.MakeEngineNoise(jeep.EngineNoise);
            jeep.MakeHonkNoise(jeep.HonkNoise);
            
            cars.Add(jeep);
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instantiate the CarLot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (Car vehicle in myDriveway.Cars)
            {
                Console.WriteLine($"The vehicle's make: {vehicle.Make}");
                Console.WriteLine($"The year: {vehicle.Year}");
                Console.WriteLine($"The model: {vehicle.Model}");
            }
            //Console.WriteLine(string.Join(", ", myDriveway.Cars.Make));
        }
    }
}
