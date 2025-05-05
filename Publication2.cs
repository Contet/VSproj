public class Publication2 : Publication
{
    public Date ReleaseDate { get; set; }

    public Publication2(string title, double price, Date releaseDate) 
        : base(title, price)
    {
        ReleaseDate = releaseDate;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Дата выхода: {ReleaseDate}");
    }
}