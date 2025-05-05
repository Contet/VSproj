public class AudioType : Publication2
{
    public double Duration { get; set; } // в минутах

    public AudioType(string title, double price, Date releaseDate, double duration)
        : base(title, price, releaseDate)
    {
        Duration = duration;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Длительность: {Duration} мин");
    }
}