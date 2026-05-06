namespace Task5;

public class Program
{
    static void Main()
    {
        const double pi = Math.PI;
        double r = 10;
        double s = pi * Math.Pow(r, 2);
        Console.WriteLine($"Площадь круга равна {s}");
        Console.ReadKey();
    }
}
