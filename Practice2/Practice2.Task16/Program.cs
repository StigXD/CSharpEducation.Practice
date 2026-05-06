namespace Practice2.Task16;

public class Program
{
    static void Main()
    {
        var num16 = 42;
        Console.WriteLine($"До: {num16}");
        FlipSign(ref num16);
        Console.WriteLine($"После: {num16}");
        Console.ReadKey();
    }

    static void FlipSign(ref int number)
    {
        number = -number;
    }

}
