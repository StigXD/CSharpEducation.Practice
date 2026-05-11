using Person;

namespace PersonTest;

public class Program
{
    static void Main()
    {
        var person1 = new Person.Person();

        var person2 = new Person.Person();
        person2.Name = "Abstract Name";

        var person3 = new Person.Person();
        person3.Age = 30;

        var person4 = new Person.Person();
        person4.Name = "Захар";
        person4.Age = 29;

        person1.Print();
        person2.Print();
        person3.Print();
        person4.Print();

        Console.ReadKey();
    }
}
