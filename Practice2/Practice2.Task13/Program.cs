namespace Practice2.Task13;

public class Program
{
    static void Main()
    {
        var matrix = CreateMatrix(3, 4);
        PrintMatrix(matrix);
        Console.ReadKey();
    }

    static int[,] CreateMatrix(int rows, int columns)
    {
        var arr = new int[rows, columns];

        Random rand = new Random();

        for (var i = 0; i < rows; i++)
            for (var j = 0; j < columns; j++)
                arr[i, j] = rand.Next(1, 101);

        return arr;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
                Console.Write($"{matrix[i, j],4} ");
            Console.WriteLine();
        }
    }

}
