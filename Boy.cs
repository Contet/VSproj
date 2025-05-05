public class Boy : Person
{
    public Boy(string name) : base(name) {}
    
    public override void ReactTo(Person other)
    {
        if (other is Girl)
            Console.WriteLine($"{name} смущенно здоровается с {other.Name}");
        else
            Console.WriteLine($"{name} кивает {other.Name}");
    }
}
