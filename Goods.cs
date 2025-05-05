public class Goods : Product
{
    protected string manufacturer;

    public Goods(string name, decimal price, string manufacturer) 
        : base(name, price)
    {
        this.manufacturer = manufacturer;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Производитель: {manufacturer}");
        Console.WriteLine($"Тип: Обычный товар");
    }
}
