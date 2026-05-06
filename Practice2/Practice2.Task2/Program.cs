namespace Practice2.Task2;

public class Program
{
    static void Main()
    {
        //a
        Console.WriteLine("Введите метры");
        var meters = int.Parse(Console.ReadLine());
        var km = meters / 1000;
        Console.WriteLine($"{km}km");

        //b
        Console.WriteLine("Введите км");
        var kilometers = int.Parse(Console.ReadLine());
        var cm = kilometers*1000*100;
        Console.WriteLine($"{cm}cm");

        //c
        Console.WriteLine("Введите м/c");
        var metersInSecond = int.Parse(Console.ReadLine());
        var kilometersInHour = metersInSecond * 3600 / 1000;
        Console.WriteLine($"{kilometersInHour}km/ч");

        //d
        Console.WriteLine("Введите C");
        var C = int.Parse(Console.ReadLine());
        var F = (C * 9/5) + 32;
        Console.WriteLine($"{F}");
        Console.ReadKey();
    }
}
