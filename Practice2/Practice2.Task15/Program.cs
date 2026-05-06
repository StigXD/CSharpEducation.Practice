namespace Practice2.Task15;

public class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.Write("Исходный: ");
        PrintArray(arr);
        InvertArray(arr);
        Console.Write("Инвертированный: ");
        PrintArray(arr);
        Console.ReadKey();
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine($"[{string.Join(", ", array)}]");
    }

    static void InvertArray(int[] array)
    {
        var left = 0;
        var right = array.Length - 1;
        while (left < right)
        {
            var temp = array[left];
            array[left] = array[right];
            array[right] = temp;
            left++;
            right--;
        }
    }

}
