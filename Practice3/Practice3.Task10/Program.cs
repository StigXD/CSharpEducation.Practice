namespace Practice3.Task10;
public class Program
{
    static void Main()
    {
        var car = new Car { Model = "Toyota LandCruiser 200" };

        PrintModel(car);

        Console.ReadKey();
    }

    public static void PrintModel(Car car)
    {
        Console.WriteLine($"Марка автомобиля: {car.Model}");
    }

}

public class Car
{
    public string Model { get; set; }
}
