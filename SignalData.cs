public class SignalData : Data
{
    private double[] signal;
    
    public SignalData(double[] data)
    {
        signal = data;
    }
    
    public override void Display()
    {
        Console.WriteLine("Сигнал: " + string.Join(", ", signal));
    }
    
    public override void Save()
    {
        Console.WriteLine("Сохранение сигнала в файл...");
    }
    
    public override void Process()
    {
        Console.WriteLine("Обработка сигнала...");
    }
}
