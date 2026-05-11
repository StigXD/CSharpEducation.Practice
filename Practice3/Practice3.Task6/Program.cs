using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;

namespace Practice3.Task6;

public class Program
{
    static void Main()
    {
        var point1 = new Point { X = 10, Y = 3 };
        var point2 = new Point { X = 0, Y = 6 };

        Console.WriteLine(Distance(point1, point2));
        Console.ReadKey();
    }

    public static double Distance(Point point1, Point point2)
    {
        return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
    }
}

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}