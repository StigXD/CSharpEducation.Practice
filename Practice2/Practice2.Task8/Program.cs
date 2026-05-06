namespace Practice2.Task8;

public class Program
{
    static void Main()
    {
        Console.Write("Введите три числа через пробел: ");
        var input = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (input?.Length != 3)
        {
            Console.WriteLine("Некорректный ввод.");
        }
        else
        {
            var a = double.Parse(input[0]);
            var b = double.Parse(input[1]);
            var c = double.Parse(input[2]);
            if (a == b || b == c || a == c)
            {
                a += 5; b += 5; c += 5;
                Console.WriteLine($"Увеличено на 5: {a}, {b}, {c}");
            }
            else
            {
                Console.WriteLine("Равных нет.");
            }
        }
        Console.ReadKey();
    }
}
