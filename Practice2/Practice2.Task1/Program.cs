using System.ComponentModel.DataAnnotations;

namespace Practice2.Task1;

public class Program
{
    static void Main()
    {
        //a
        for (var i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();

        //b
        var j = 0;
        while (j < 10) 
        {
            Console.WriteLine(j);
            j++;
        }

        Console.WriteLine();

        //c
        var k = 0;
        do 
        {
            Console.WriteLine(k);
            k++;

        }
        while (k < 10);

        //d
        string phrase ="";
        for(var i = 0;i < 4;i++)
        {
            var word = Console.ReadLine();
            phrase += word + " "; 
        }

        Console.WriteLine(phrase);

        Console.WriteLine();

        //e
        var m = 0;
        var words = "";
        while (m < 3)
        {
            words += Console.ReadLine() + " ";
            m++;
        }
        Console.WriteLine(words);

        Console.WriteLine();

        //f
        var n = 0;
        var wordss = "";
        do
        {
            wordss += Console.ReadLine() + " ";
            n++;

        } while (n < 3);
        Console.WriteLine(wordss);

        Console.ReadKey();
    }
}
