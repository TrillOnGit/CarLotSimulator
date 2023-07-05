using System;

namespace CarLotSimulator;

public class Car
{
    //Create a separate class file called Car
    //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
    //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    //The methods should take one string parameter: the respective noise property
    public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
    {
        EngineNoise = engineNoise;
        Year = year;
        Make = make;
        Model = model;
        HonkNoise = honkNoise;
        IsDriveable = isDrivable;
        CarLot.NumberOfCars++;
    }

    public Car()
    {
        CarLot.NumberOfCars++;
    }

    public int Year { get; set; }

    public string Make { get; set; }

    public string Model { get; set; }

    public string EngineNoise { get; set; }

    public string HonkNoise { get; set; }

    public bool IsDriveable { get; set; }

    public void MakeEngineNoise(string engineSound)
    {
        Console.WriteLine($"The engine makes the noise: {engineSound}");
    }

    public void MakeHonkNoise(string honkSound)
    {
        Console.WriteLine($"The car's horn sound is: {honkSound}");
    }
}