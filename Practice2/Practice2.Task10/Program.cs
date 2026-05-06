namespace Practice2.Task10;

public class Program
{
    static void Main(string[] args)
    {
        if (args.Length >= 1 && int.TryParse(args[0], out int size))
        {
            int[] arr = CreateArray(size);
            PrintArray(arr);
        }
        else
        {
            Console.WriteLine("Передайте размер массива через аргументы консоли");
        }
        Console.WriteLine();
    }

    static int[] CreateArray(int size)
    {
        var arr = new int[size];
        foreach (var item in arr)
            arr[item] = size;
        return arr;
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine($"[{string.Join(", ", array)}]");
    }

}
