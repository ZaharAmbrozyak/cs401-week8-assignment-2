namespace cs401_week8_assignment_2;

public abstract class Resource
{
    public string Name
    {
        get;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty!");
            }

            field = value;
        }
    }
    
    public bool IsOpen { get; protected set; }

    protected Resource(string name)
    {
        Name = name;
        IsOpen = false;
    }
    
    public abstract void Open();

    public abstract void Close();
}