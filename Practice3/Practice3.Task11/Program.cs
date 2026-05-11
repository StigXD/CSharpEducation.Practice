namespace Practice3.Task11;

public class Program
{
    static void Main()
    {
        var book = new Book { Name = "Hello", Author = "World" };

        Console.WriteLine(GetInfo(book));

        Console.ReadKey();
    }

    public static string GetInfo(Book book)
    {
        return $"Книга: \"{book.Name}\" автора {book.Author}";
    }

}

public class Book
{
    public string Name { get; set; }
    public string Author { get; set; }
}