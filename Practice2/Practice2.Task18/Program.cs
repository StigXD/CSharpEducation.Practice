namespace Practice2.Task18;

public class Program
{
    static void Main()
    {
        int[] arr = { -3, 5, -1, 8, 0, -7, 12 };

        Console.Write("Исходный: ");

        PrintArray(arr);

        var resultArray = RemoveNegatives(arr, out int removedCount);

        Console.Write("Результат: ");

        PrintArray(resultArray);

        Console.WriteLine($"Удалено отрицательных: {removedCount}");

        Console.ReadKey();
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine($"[{string.Join(", ", array)}]");
    }

    static int[] RemoveNegatives(int[] source, out int removedCount)
    {
        var positives = source.Where(x => x >= 0).ToArray();
        removedCount = source.Length - positives.Length;
        return positives;
    }
}
