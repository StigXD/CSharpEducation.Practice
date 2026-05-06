namespace Practice2.Task22;

public class Program
{
    static void Main()
    {
        var rand = new Random();
        var secretNumber = rand.Next(1, 101);
        var maxAttempts = 10;
        var attempts = 0;
        int value;

        Console.WriteLine("Загадано число от 1 до 100.");

        Console.WriteLine($"У вас есть {maxAttempts} попыток.");

        while (attempts < maxAttempts)
        {
            Console.Write($"Попытка {attempts + 1}: Введите число: ");

            if (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Введите целое число!");
                continue;
            }

            attempts++;

            if (value == secretNumber)
            {
                Console.WriteLine($"Поздравляю! Вы угадали число {secretNumber} за {attempts} попыток!");
                return;
            }
            else if (value < secretNumber)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else
            {
                Console.WriteLine("Загаданное число меньше.");
            }
        }

        Console.WriteLine($"Вы проиграли! Загаданное число: {secretNumber}");

        Console.ReadKey();
    }
}