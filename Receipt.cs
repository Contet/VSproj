class Receipt
{
    public int Number { get; set; }
    public string Date { get; set; }
    public double Amount { get; set; }

    public Receipt()
    {
        Console.WriteLine("Создана квитанция конструктором по умолчанию");
        Number = 0;
        Date = "01.01.1970";
        Amount = 0;
    }

    public Receipt(int number, string date, double amount)
    {
        Console.WriteLine($"Создана квитанция №{number} через конструктор с параметрами");
        Number = number;
        Date = date;
        Amount = amount;
    }

    public Receipt(Receipt other)
    {
        Console.WriteLine($"Создана копия квитанции №{other.Number}");
        Number = other.Number;
        Date = other.Date;
        Amount = other.Amount;
    }

    ~Receipt()
    {
        Console.WriteLine($"Удалена квитанция №{Number}");
    }



    // Тестовый метод
    public static void RunDemo()
    {
        Console.Clear();
        Console.WriteLine("=== ДЕМО КВИТАНЦИЙ ===");

        Receipt r1 = new Receipt();
        Receipt r2 = new Receipt(1001, "15.05.2023", 1250.75);
        Receipt r3 = new Receipt(r2);

        Receipt[] receipts = new Receipt[3];
        receipts[0] = new Receipt(2001, "20.05.2023", 500.0);
        receipts[1] = new Receipt(2002, "21.05.2023", 750.5);
        receipts[2] = new Receipt(receipts[0]);

        Console.WriteLine("\nВсе квитанции:");
        foreach (var r in receipts)
        {
            Console.WriteLine($"№{r.Number} от {r.Date} - {r.Amount:F2} руб.");
        }
    }
}