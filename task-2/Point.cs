namespace task_2;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Print()
    {
        Console.WriteLine($"Point. X: {X}, Y: {Y}");
    }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}