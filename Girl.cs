public class Girl : Person
{
    public Girl(string name) : base(name) {}
    
    public override void ReactTo(Person other)
    {
        if (other is Boy)
            Console.WriteLine($"{name} кокетливо улыбается {other.Name}");
        else
            Console.WriteLine($"{name} дружелюбно приветствует {other.Name}");
    }
}
