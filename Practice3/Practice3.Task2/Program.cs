namespace Practice3.Task2;

public class Program
{
    static void Main()
    {
        var student = new Student();
        student.Name = "Прокопий";
        student.Age = 33;
        student.AvgPoint = (double)10 / 3;
        student.Print();

        var student2 = new Student();
        student.Name = "Феофан";
        student.Age = 13;
        student.AvgPoint = (double)10 / 1;
        student.Print();

        Console.ReadKey();
    }
}

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    private double _avgPoint;

    public double AvgPoint
    {
        get { return _avgPoint; }
        set 
        {
            if (value <= 5 && value >= 0)
            {
                _avgPoint = value;
            }
            else
            {
                Console.WriteLine($"Student {Name} - Incorrect average point");
                _avgPoint = 0;
            }
        }
    }

    public void Print()
    {
        Console.WriteLine($"Student {Name}, age {Age}, average point {AvgPoint}");
    }
}