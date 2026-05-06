namespace Practice2.Task19;

public class Program
{
    static void Main()
    {
        var arr = GenerateRandomArray(10, 1, 100);

        PrintArray(arr);

        int min = arr.Min(), max = arr.Max();

        Console.WriteLine($"Мин: {min}, Макс: {max}, Разница: {max - min}");

        Console.ReadKey();
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine($"[{string.Join(", ", array)}]");
    }

    static int[] GenerateRandomArray(int size, int min, int max)
    {
        var arr = new int[size];

        Random rand = new Random();

        for (int i = 0; i < size; i++)
            arr[i] = rand.Next(min, max + 1);
        return arr;
    }
}
