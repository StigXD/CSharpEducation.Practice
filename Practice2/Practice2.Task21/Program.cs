namespace Practice2.Task21;

public class Program
{
    static void Main()
    {
        var rand = new Random();

        var secretNumber = rand.Next(1, 101);
        int value;

        Console.WriteLine("Загадано число от 1 до 100.");

        do
        {
            Console.Write("Какое число? ");

            if (int.TryParse(Console.ReadLine(), out value))
            {
                if (value < secretNumber)
                    Console.WriteLine("Загаданное число больше");
                else if (value > secretNumber)
                    Console.WriteLine("Загаданное число меньше");
                else
                    Console.WriteLine($"Поздравляю! Вы угадали число {secretNumber}!");
            }
            else
            {
                Console.WriteLine("Введите целое число!");
            }

        } while (value != secretNumber);

        Console.ReadKey();
    }
}
