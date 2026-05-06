namespace Practice2.Task20;

public class Program
{
    static void Main()
    {
        int[,] matrix = GenerateRandomMatrix(4, 5, 1, 100);

        PrintMatrix(matrix);

        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            var rowMin = int.MaxValue;
            var rowMax = int.MinValue;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < rowMin) rowMin = matrix[i, j];
                if (matrix[i, j] > rowMax) rowMax = matrix[i, j];
            }
            Console.WriteLine($"Строка {i + 1}: мин = {rowMin}, макс = {rowMax}, разница = {rowMax - rowMin}");
        }
        Console.ReadKey();
    }

    static int[,] GenerateRandomMatrix(int rows, int cols, int min, int max)
    {
        var arr = new int[rows, cols];

        var rand = new Random();

        for (var i = 0; i < rows; i++)
            for (var j = 0; j < cols; j++)
                arr[i, j] = rand.Next(min, max + 1);
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
