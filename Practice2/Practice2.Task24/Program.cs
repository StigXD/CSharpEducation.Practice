namespace Practice2.Task24;

public class Program
{
    static void Main()
    {
        foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
        {
            Console.WriteLine($"- {day}");
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
