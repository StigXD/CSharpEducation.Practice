namespace Practice2.Task25;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер дня недели (1–7):");

        if (int.TryParse(Console.ReadLine(), out var dayNumber) && dayNumber >= 1 && dayNumber <= 7)
        {
            var day = (DayOfWeek)(dayNumber - 1);

            Console.WriteLine($"День недели: {day}");
        }
        else
        {
            Console.WriteLine("Введите число от 1 до 7.");
        }

        Console.ReadKey();
    }

    public enum DayOfWeek
    {
        Понедельник,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }
}
