namespace Practice2.Task5
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите 2 числа для сравнения");

            Console.WriteLine("Первое число");
            var value1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Второе число");
            var value2 = int.Parse(Console.ReadLine());

            Console.WriteLine(
                value1 == value2 ? "Числа равны"
                : value1 > value2 ? $"Число {value1} больше"
                : $"Число {value2} больше");

            Console.ReadKey();
        }
    }
}
