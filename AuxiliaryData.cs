public class AuxiliaryData : Data
{
    private Dictionary<string, string> metadata;
    
    public AuxiliaryData(Dictionary<string, string> meta)
    {
        metadata = meta;
    }
    
    public override void Display()
    {
        Console.WriteLine("Метаданные:");
        foreach (var item in metadata)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
    
    public override void Save()
    {
        Console.WriteLine("Сохранение метаданных в конфигурацию...");
    }
    
    public override void Process()
    {
        Console.WriteLine("Анализ метаданных...");
    }
}
