public class ProcessedResult : Data
{
    private object result;
    
    public ProcessedResult(object res)
    {
        result = res;
    }
    
    public override void Display()
    {
        Console.WriteLine($"Результат обработки: {result}");
    }
    
    public override void Save()
    {
        Console.WriteLine("Сохранение результата в базу данных...");
    }
    
    public override void Process()
    {
        Console.WriteLine("Дополнительная обработка результата...");
    }
}
