namespace Practice2.Task17;

public class Program
{
    static void Main()
    {
        var x = 10;
        var y = 20;

        Console.WriteLine($"До: x={x}, y={y}");

        Swap(ref x, ref y);

        Console.WriteLine($"После: x={x}, y={y}");

        Console.ReadKey();
    }

    static void Swap(ref int a, ref int b)
    {
        var temp = a;
        a = b;
        b = temp;
    }
}
