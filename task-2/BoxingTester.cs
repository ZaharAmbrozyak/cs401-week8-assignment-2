namespace task_2;

public static class BoxingTester
{
    public static void Test()
    {
        var a = 10;
        
        // Boxing. Копіюємо тип int зі стеку у купу та зберігаємо посилання в змінній object
        object b = a;
        
        // Unboxing. Витягуємо значення об'єкта з купи і копіюємо у стек у змінну с
        var c = (int)b;
        
        Console.WriteLine($"int a: {a}");
        Console.WriteLine($"Boxed b: {b}");
        Console.WriteLine($"Unboxed c: {c}");
    }
}