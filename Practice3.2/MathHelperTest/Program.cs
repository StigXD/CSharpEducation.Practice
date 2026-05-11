using MathHelper;

namespace MathHelperTest;

public class Program
{
    static void Main()
    {
        var calculator = new MathHelper.MathHelper();

        try
        {
            Console.WriteLine($"5 + 8 = {calculator.Summ(5, 8)}");
            Console.WriteLine($"5.6 + 8.43 = {calculator.Summ(5.6, 8.43)}");
            Console.WriteLine($"55 - 12 = {calculator.Subtract(55, 12)}");
            Console.WriteLine($"3.5 - 8.4 = {calculator.Subtract(3.5, 8.4)}");
            Console.WriteLine($"43 * 85 = {calculator.Multiply(43, 85)}");
            Console.WriteLine($"5.87 * 8.34 = {calculator.Multiply(5.87, 8.34)}");
            Console.WriteLine($"5 / 8 = {calculator.Divide(5, 8)}");
            Console.WriteLine($"532 / 8 = {calculator.Divide(532, 8)}");
            Console.WriteLine($"5.111 / 8.056 = {calculator.Divide(5.111, 8.056)}");
            Console.WriteLine($"0 / 8 = {calculator.Divide(0, 8)}");
            Console.WriteLine($"2345 / 0 = {calculator.Divide(2345, 0)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadKey();
    }
}
