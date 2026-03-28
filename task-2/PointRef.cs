namespace task_2;

public class PointRef
{
    public int X { get; set; }
    public int Y { get; set; }

    public void Print()
    {
        Console.WriteLine($"PointRef. X: {X}, Y: {Y}");
    }

    public PointRef(int x, int y)
    {
        X = x;
        Y = y;
    }
}