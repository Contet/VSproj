public abstract class Data
{
    public abstract void Display();
    public abstract void Save();
    public abstract void Process();



        // Тестовый метод
    public static void RunDemo(){
        Console.WriteLine("\n=== Демонстрация иерархии Data ===");
        
        Data[] dataset = {
            new SignalData(new double[] {1.2, 2.3, 3.4}),
            new ProcessedResult("Анализ завершен"),
            new AuxiliaryData(new Dictionary<string, string> {
                {"Автор", "Иванов"}, 
                {"Дата", "2023-05-20"}
            })
        };
        
        foreach (var data in dataset)
        {
            data.Display();
            data.Process();
            data.Save();
            Console.WriteLine();
        }

    }
}




