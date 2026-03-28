namespace task_3;

public class DataItem
{
    public string Id { get; set; }
    public byte[] Payload { get; set; }

    public long GetSize()
    {
        return Payload.Length;
    }
    
}