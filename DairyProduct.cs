public class DairyProduct : Goods
{
    protected DateTime expirationDate;

    public DairyProduct(string name, decimal price, string manufacturer, DateTime expirationDate) 
        : base(name, price, manufacturer)
    {
        this.expirationDate = expirationDate;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Срок годности: {expirationDate:dd.MM.yyyy}");
        Console.WriteLine($"Тип: Молочный продукт");
    }
}