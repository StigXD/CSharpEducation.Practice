using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task6;

public class Program
{
    static void Main()
    {
        double katet1 = 10;
        double katet2 = 20;
        double hypotenuse = 30;
        
        Console.WriteLine(FindKatet(hypotenuse, katet1));
        Console.WriteLine(FindHypotenuse(katet1, katet2));
        Console.ReadKey();
    }

    static double FindKatet(double hypotenuse, double katet)
    {
        var result = Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(katet, 2));
        return result;
    }

    static double FindHypotenuse(double katet1, double katet2)
    {
        var result = Math.Sqrt(Math.Pow(katet1, 2) + Math.Pow(katet2, 2));
        return result;
    }
}
