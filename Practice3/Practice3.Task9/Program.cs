namespace Practice3.Task9;

public class Program
{
    static void Main()
    {
        var student = new Student {Name = "Макар", Age = 12 };

        Console.WriteLine($"{student.Name}, {student.Age}");

        MakeAnonymous(student);

        Console.WriteLine($"{student.Name}, {student.Age}");

        Console.ReadKey();
    }

    public static void MakeAnonymous(Student student)
    {
        student.Name = "Аноним";
    }
}

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}
