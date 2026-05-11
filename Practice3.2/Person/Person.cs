namespace Person;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person()
    {
        Name = "Неизвестно";
        Age = 0;
    }

    public void Print()
    {
        Console.WriteLine($"Имя {Name} возраст {Age}");
    }
}
