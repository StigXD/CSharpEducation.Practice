namespace Practice2.Task12;

public class Program
{
    static void Main()
    {
       Console.Write("Введите количество строк: ");
       if (int.TryParse(Console.ReadLine(), out int count) && count > 0)
       {
           string[] arr = new string[count];
           for (int i = 0; i < count; i++)
           {
               Console.Write($"Строка {i + 1}: ");
               arr[i] = Console.ReadLine() ?? "";
           }
           Console.WriteLine("Введённые строки:");
           PrintArray(arr);
       }
       else
       {
           Console.WriteLine("Некорректный ввод.");
       }
       Console.ReadKey();
    }

    static void PrintArray(string[] array)
    {
        Console.WriteLine($"[{string.Join(", ", array)}]");
    }
}
