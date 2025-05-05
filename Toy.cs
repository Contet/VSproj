public class Toy : Product
{
    protected string ageGroup;

    public Toy(string name, decimal price, string ageGroup) 
        : base(name, price)
    {
        this.ageGroup = ageGroup;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Возрастная группа: {ageGroup}");
        Console.WriteLine($"Тип: Игрушка");
    }
}
