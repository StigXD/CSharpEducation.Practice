namespace Practice2.Task4;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Введите высоту треугольника");
        //a
        var heigth = int.Parse(Console.ReadLine());
      
        //c
        Console.WriteLine("Введите символ");
        var symbol = char.Parse(Console.ReadLine());

        for (var i = 0; i < heigth; i++)
        {
            for(var j = 0; j < i+1;j++)
                Console.Write(symbol);
            Console.Write('\n');
        }

        Console.WriteLine();
        //b
        for (var i = 0; i < heigth; i++)
        {
            for (var j = 0; j < heigth-1 - i; j++)
                Console.Write(" ");

            for (var k = 0; k < i+1; k++)
                Console.Write(symbol);

            Console.Write('\n');
        }

        Console.ReadKey();
    }
}
