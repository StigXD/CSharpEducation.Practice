namespace Practice3.Task3;

public class Program
{
    static void Main()
    {
        var a = 3;
        var b = 7;
        var calculate = new Calculator();

        Console.WriteLine($"Calculate {a} + {b} = {calculate.Add(a, b)}");
        Console.WriteLine($"Calculate {a} - {b} = {calculate.Subtract(a, b)}");
        Console.WriteLine($"Calculate {a} * {b} = {calculate.Multiply(a, b)}");
        Console.WriteLine($"Calculate {a} / {b} = {calculate.Divide(a, b)}");

        Console.ReadKey();
    }
}

public class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Деление на ноль невозможно.");
        return a / b;
    }
}