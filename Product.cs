using System;
using System.Collections.Generic;

public abstract class Product
{
    protected string name;
    protected decimal price;
    protected static List<Product> products = new List<Product>();

    protected Product(string name, decimal price)
    {
        this.name = name;
        this.price = price;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Товар: {name}");
        Console.WriteLine($"Цена: {price} руб.");
    }

    public virtual void Add()
    {
        products.Add(this);
        Console.WriteLine($"{name} добавлен в список товаров");
    }

    public static void ShowAll()
    {
        Console.WriteLine("\n=== СПИСОК ВСЕХ ТОВАРОВ ===");
        foreach (var product in products)
        {
            product.Show();
            Console.WriteLine("----------------------");
        }
    }



    // Тестовый метод
    public static void RunDemo(){        

        // Создаем продукты
        Toy toy1 = new Toy("Конструктор", 1500, "3+");
        Goods goods1 = new Goods("Наушники", 2500, "Sony");
        DairyProduct milk = new DairyProduct("Молоко", 80, "Простоквашино", 
            DateTime.Now.AddDays(7));

        // Добавляем в список
        toy1.Add();
        goods1.Add();
        milk.Add();

        // Просматриваем список
        Product.ShowAll();
    }

}
