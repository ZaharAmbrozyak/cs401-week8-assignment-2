namespace task_2;

public class BoxingTester
{
    public void Test()
    {
        var a = 10;
        object b = a;
        var c = (int)b;
        
        Console.WriteLine($"int a: {a}");
        Console.WriteLine($"Boxed b: {b}");
        Console.WriteLine($"Unboxed c: {c}");
    }
}