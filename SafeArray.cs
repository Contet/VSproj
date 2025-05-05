public class SafeArray
{
    private static int LIMIT = 80;  // максимальный размер
    private int[] arr = new int[LIMIT];
    private int lowerBound;  
    private int upperBound;  

    public SafeArray()
    {
        lowerBound = 0;
        upperBound = LIMIT - 1;
    }

    public SafeArray(int low, int high)
    {
        if (high - low + 1 > LIMIT)
            throw new ArgumentException("Превышен максимальный размер массива");

        lowerBound = low;
        upperBound = high;
        arr = new int[high - low + 1];
    }

    // Индексатор с проверкой границ
    public int this[int index]
    {
        get
        {
            if (index < lowerBound || index > upperBound)
                throw new IndexOutOfRangeException($"Индекс {index} выходит за границы массива [{lowerBound}..{upperBound}]");
            return arr[index - lowerBound];
        }
        set
        {
            if (index < lowerBound || index > upperBound)
                throw new IndexOutOfRangeException($"Индекс {index} выходит за границы массива [{lowerBound}..{upperBound}]");
            arr[index - lowerBound] = value;
        }
    }

    // Метод для получения размера массива
    public int Length => upperBound - lowerBound + 1;

    public void Print()
    {
        Console.WriteLine($"Массив [{lowerBound}..{upperBound}]:");
        for (int i = lowerBound; i <= upperBound; i++)
        {
            Console.WriteLine($"[{i}] = {this[i]}");
        }
    }




    // Тестовый метод
    public static void RunDemo(){
        try
        {
            // Создаем массив с границами от 100 до 110
            SafeArray myArray = new SafeArray(100, 110);
            
            // Заполняем массив
            for (int i = 100; i <= 110; i++)
            {
                myArray[i] = i * 2;
            }
            
            myArray.Print();
            
            // Пробуем обратиться к несуществующему индексу
            Console.WriteLine(myArray[99]);  // Выбросит исключение
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}