namespace Practice2.Task7;

public class Program
{
    static void Main()
    {
        string text = "Привет, Мир!";

        Console.WriteLine($"Исходная: {text}");
        Console.WriteLine($"Верхний:  {text.ToUpper()}");
        Console.WriteLine($"Нижний:  {text.ToLower()}");
        Console.WriteLine($"Заглавная: {char.ToUpper(text[0]) + text.Substring(1)}\n");

        Console.ReadKey();
    }
}

