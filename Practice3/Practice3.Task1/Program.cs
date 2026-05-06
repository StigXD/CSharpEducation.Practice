namespace Practice3.Task1;

public class Program
{
    static void Main()
    {
        var student = new Student();
        student.Name = "Прокопий";
        student.Age = 33;
        student.Print();

        Console.ReadKey();
    }
}

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Print()
    {
        Console.WriteLine($"Student {Name} age {Age}");
    }
}