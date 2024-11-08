using System;

public class Car
{
    public string Color { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string color, string model, int year)
    {
        Color = color;
        Model = model;
        Year = year;
        Console.WriteLine( "your car is ready!!" );
    }
// class takhrib konande
    ~Car()
    {
        Console.WriteLine("your car is removed from cache.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("red", "supra", 2024);
    }
}
