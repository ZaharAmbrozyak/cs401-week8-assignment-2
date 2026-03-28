namespace task_2;

class Program
{
    static void Main(string[] args)
    {
        // при створенні нового struct, ми робимо копію даних у памяті
        var point1 = new Point(1, 1);
        var point2 = point1;

        point2.X = 67;
        
        Console.WriteLine("Only point2 X has been changed!");
        point1.Print();
        point2.Print();
        Console.Write("\n");
        
        // тут вже йдуть класи, і reference2 отримує посилання на reference1, а не повну копію даних
        var reference1 = new PointRef(2, 2);
        var reference2 = reference1;

        reference2.X = 67;
        
        Console.WriteLine("Both X values has been changed!");
        reference1.Print();
        reference2.Print();
        
        BoxingTester.Test();
    }
}