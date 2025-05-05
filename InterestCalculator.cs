class InterestCalculator
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("=== РАСЧЕТ ВКЛАДА ===");

        Console.Write("Введите сумму вклада: ");
        double amount = double.Parse(Console.ReadLine());

        Console.Write("На сколько лет: ");
        int years = int.Parse(Console.ReadLine());

        Console.Write("Процентная ставка (%): ");
        double rate = double.Parse(Console.ReadLine());

        Console.WriteLine("\nГод\tСумма");
        for (int i = 1; i <= years; i++)
        {
            amount += amount * rate / 100;
            Console.WriteLine($"{i}\t{amount:F2} руб.");
        }

        Console.WriteLine($"\nИтоговая сумма: {amount:F2} руб.");
    }
}