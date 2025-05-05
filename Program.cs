// Точка входа во все лабы
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== ГЛАВНОЕ МЕНЮ ===");
            Console.WriteLine("1.lab Расчет банковского вклада");
            Console.WriteLine("2.lab Работа с квитанциями");
            Console.WriteLine("3.lab Работа с SageArray");
            Console.WriteLine("4.lab Работа с Publication");
            Console.WriteLine("5.lab Работа с Product"); // 5.1 lab
            Console.WriteLine("6.lab Работа с Person"); // 5.2.1 lab
            Console.WriteLine("7.lab Работа с Data"); // 5.2.2 lab
            Console.WriteLine("0. Выход");
            Console.Write("Ваш выбор: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    InterestCalculator.Run();
                    break;
                case "2":
                    Receipt.RunDemo();
                    break;
                case "3":
                    SafeArray.RunDemo();
                    break;
                case "4":
                    Publication.RunDemo();
                    break;
                case "5":
                    Product.RunDemo();
                    break;
                case "6":
                    Person.RunDemo();
                    break;
                case "7":
                    Data.RunDemo();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Неверный ввод!");
                    break;
            }

            Console.WriteLine("\nНажмите Enter для продолжения...");
            Console.ReadLine();
        }
    }
}