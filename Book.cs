public class Book : Publication2
{
    public int PageCount { get; set; }

    public Book(string title, double price, Date releaseDate, int pageCount)
        : base(title, price, releaseDate)
    {
        PageCount = pageCount;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Количество страниц: {PageCount}");
    }
}