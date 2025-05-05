using System;
using System.Collections.Generic;

public abstract class Person
{
    protected string name;
    
    public Person(string name)
    {
        this.name = name;
    }
    
    public virtual void ReactTo(Person other)
    {
        Console.WriteLine($"{name} нейтрально реагирует на {other.name}");
    }
    
    public string Name => name;



    // Тестовый метод
    public static void RunDemo(){
        
        Console.WriteLine("=== Демонстрация иерархии Person ===");
        
        Person alice = new Girl("Алиса");
        Person bob = new Boy("Боб");
        Person eve = new Girl("Ева");
        
        alice.ReactTo(bob); 
        bob.ReactTo(alice); 
        eve.ReactTo(alice); 
        
    }

}
