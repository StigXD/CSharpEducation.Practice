namespace Practice2.Task6;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Меню");
        Console.WriteLine("1. Параметры указываются программно");
        Console.WriteLine("2. Ввод параметров через консоль");
        Console.WriteLine("3. Параметры передаются через аргументы командной строки");
        Console.WriteLine("Выберите пункт меню");

        if (int.TryParse(Console.ReadLine(), out int choose))
        {
            switch (choose)
            {
                case 1:
                    {
                        var phrase = "qwertyqwertyqwertyqwertyqwerty";
                        var inputChar = 'q';

                        Console.WriteLine($"Процент вхождения {inputChar} в строку {phrase} = {PercentageOccurrence(phrase, inputChar)}");

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Введите строку");
                        var phrase = Console.ReadLine();

                        if (string.IsNullOrEmpty(phrase))
                        {
                            Console.WriteLine("Ошибка ввода строки");
                            return;
                        }

                        Console.WriteLine("Введите символ для поиска");
                        var inputChar = Console.ReadLine();

                        if (string.IsNullOrEmpty(inputChar))
                        {
                            Console.WriteLine("Ошибка ввода символа");
                            return;
                        }

                        Console.WriteLine($"Процент вхождения {inputChar} в строку {phrase} = {PercentageOccurrence(phrase, inputChar[0])}");

                        break;
                    }
                case 3:
                    {
                        var phrase = args[0];
                        var inputChar = args[1][0];
                        Console.WriteLine($"Процент вхождения {inputChar} в строку {phrase} = {PercentageOccurrence(phrase, inputChar)}");
                        break;
                    }
            }
        }
        else
        {
            Console.WriteLine("Ошибка выбора пункта меню");
            return;
        }

        Console.ReadKey();
        }
    public static double PercentageOccurrence(string text, char findChar)
    {
        double percent;

        var count = 0;
        foreach (var c in text)
        {
            if (c == findChar)
                count++;
        }

        return percent = Math.Round((double)count * 100 / text.Length, 2);
    }

    }
