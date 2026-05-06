namespace Practice3.Task5;

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
    public int PublicationYear { get; set; }

    public Book(string title, string author, int publicationYear)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
    }

    public Book(string title, string author) : this(title, author, 0) { }

    public Book(string title) : this(title, "Неизвестный автор", 0) { }

    public Book() : this("Неизвестное название") { }

    public void Print()
    {
        Console.WriteLine($"Название: {Title}");

        if (!string.IsNullOrEmpty(Author) && Author != "Неизвестный автор")
            Console.WriteLine($"Автор: {Author}");
        else
            Console.WriteLine($"Автор: Неизвестен");

        if (PublicationYear > 0)
            Console.WriteLine($"Год издания: {PublicationYear}");
        else
            Console.WriteLine("Год издания: Не указан");
    }

}