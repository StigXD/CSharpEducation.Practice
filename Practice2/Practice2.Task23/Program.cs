namespace Practice2.Task23;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Проверка високосного года");
        Console.Write("Введите год: ");
        if (int.TryParse(Console.ReadLine(), out var year))
        {
            var isLeap = (year % 400 == 0) || (year % 100 != 0 && year % 4 == 0);
            Console.WriteLine($"{year} — {(isLeap ? "високосный" : "невисокосный")} год.");
        }
        else
        {
            Console.WriteLine("❗ Некорректный ввод.");
        }

        Console.ReadKey();
    }
}
