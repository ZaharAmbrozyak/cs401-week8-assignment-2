namespace cs401_week8_assignment_2;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name)
    {
        
    }

    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine($"{Name} has been opened");
    }

    public override void Close()
    {
        if (!IsOpen)
        {
            Console.WriteLine($"{Name} is not opened!");
        }
        else
        {
            IsOpen = false;
            Console.WriteLine($"{Name} has been closed");
        }
    }

    public void Dispose()
    {
        Console.WriteLine($"${Name} has been disposed");
        Close();
    }
}