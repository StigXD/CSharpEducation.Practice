namespace Practice2.Task9;

public class Program
{
    static void Main(string[] args)
    {
        var arr9 = CreateArray(int.Parse(args[0]));
        PrintArray(arr9);
        Console.WriteLine();
        Console.ReadKey();
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
