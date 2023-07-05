using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public CarLot(List<Car> cars)
    {
        Cars = cars;
    }

    public List<Car> Cars { get; set; }

    public static int NumberOfCars { get; set; } = 0;
}