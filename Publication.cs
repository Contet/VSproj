public class Publication
{
    public string Title { get; set; }
    public double Price { get; set; }

    public Publication(string title, double price)
    {
        Title = title;
        Price = price;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Название: {Title}");
        Console.WriteLine($"Цена: {Price} руб.");
    }



    // Тестовый метод
    public static void RunDemo(){
        Console.WriteLine("=== Издательская система ===");
        
        // Создаем дату
        Date releaseDate = new Date(15, 5, 2023);
        
        // Создаем книги и аудиозаписи
        Book book = new Book("Война и мир", 1200, releaseDate, 1225);
        AudioType audioBook = new AudioType("Война и мир (аудио)", 850, releaseDate, 36.5);
        
        Console.WriteLine("\nИнформация о книге:");
        book.Display();
        
        Console.WriteLine("\nИнформация об аудиокниге:");
        audioBook.Display();
        
        // Работа с датой
        Console.WriteLine("\nВведите новую дату выхода (дд мм гггг):");
        string[] dateParts = Console.ReadLine().Split();
        Date newDate = new Date(
            int.Parse(dateParts[0]),
            int.Parse(dateParts[1]),
            int.Parse(dateParts[2]));
        
        book.ReleaseDate = newDate;
        audioBook.ReleaseDate = newDate;
        
        Console.WriteLine("\nОбновленная информация:");
        book.Display();
        audioBook.Display();

    }

}