namespace Practice2.Task3;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Введите переменные a, b, f. (a != 0)");
        int a, b, f;
        do
        {
            a = int.Parse(Console.ReadLine());
            if (a == 0)
                Console.WriteLine("a не должно быть равно 0!");
        } while (a == 0);
        b = int.Parse(Console.ReadLine());
        f = int.Parse(Console.ReadLine());

        Console.WriteLine((a + b - f / a) + f * a * a - (a + b));

        Console.ReadKey();
    }
}
