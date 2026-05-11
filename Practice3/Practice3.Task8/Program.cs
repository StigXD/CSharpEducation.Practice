namespace Practice3.Task8;

public class Program
{
    static void Main()
    {
        var rectangle = new Rectangle { Height = 3, Width = 7 };

        Console.WriteLine(Square(rectangle));
        Console.ReadKey();
    }

    public static double Square(Rectangle rectangle)
    {
        return rectangle.Height * rectangle.Width;
    }
}

public struct Rectangle
{
    public double Height { get; set; }
    public double Width { get; set; }
}
