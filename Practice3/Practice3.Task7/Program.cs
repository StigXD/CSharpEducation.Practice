namespace Practice3.Task7;

public class Program
{
    static void Main()
    {
        var month = Months.Июнь;

        Console.WriteLine(CountDays (month));

        Console.ReadKey();
    }
    
    public static int CountDays(Months month)
    {
        return month switch
        {
            Months.Февраль => 28,
            Months.Апрель or 
            Months.Июнь or 
            Months.Сентябрь or 
            Months.Ноябрь => 30,
            _ => 31
        };
    }
}

public enum Months
{
    Январь, Февраль, Март, Апрель, Май, Июнь,
    Июль, Август, Сентябрь, Октябрь, Ноябрь, Декабрь
}
