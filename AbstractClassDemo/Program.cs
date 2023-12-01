

Car car = new Car();



Console.ReadLine();

Book book = new Book();

public abstract class InventoryItem
{
    public string ProductName { get; set; }
    public int QuantityOnHand { get; set; } 
}

public abstract class Vehicle
{
    public string VIN { get; set; }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public int YearManufactured { get; set; }
}

public class Car : Vehicle
{
    public int NumberOfWheels { get; set; } = 4;
}