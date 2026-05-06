namespace Practice2.Task11;

public class Program
{
    static void Main(string[] args)
    {
        if (args.Length >= 2 && int.TryParse(args[0], out int size) && int.TryParse(args[1], out int value))
        {
            int[] arr = CreateArray(size, value);
            PrintArray(arr);
        }
        else
        {
            Console.WriteLine("Размер и знчения массива нужно передавать через аргументы консоли");
        }
        Console.WriteLine();
    }

    static int[] CreateArray(int size, int value)
    {
        var arr = new int[size];
        foreach (var item in arr)
            arr[item] = value;
        return arr;
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine($"[{string.Join(", ", array)}]");
    }

}
