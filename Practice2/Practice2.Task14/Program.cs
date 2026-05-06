namespace Practice2.Task14;

public class Program
{
    static void Main()
    {
        int[] arr = CreateEmptyArray(6);
        for (int i = 0; i < arr.Length; i++)
            arr[i] = i * 10;
        PrintArray(arr);
        Console.ReadKey();
    }

    static int[] CreateEmptyArray(int size) => new int[size];

    static void PrintArray(int[] array)
    {
        Console.WriteLine($"[{string.Join(", ", array)}]");
    }

}
