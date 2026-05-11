namespace Practice3.Task4;

public class Program
{
    static void Main()
    {
        var book = new Book();
        var book2 = new Book("Death Note", "Ruke");

        book.Print();
        book2.Print();

        Console.ReadKey();
    }
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book()
    {
        Title = "Lord of the rings";
        Author = "J. R. R. Tolkien";
    }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void Print()
    {
        Console.WriteLine($"{Title}, {Author}");
    }
}