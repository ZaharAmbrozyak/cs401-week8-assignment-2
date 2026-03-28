namespace task_3;

public class DataItem
{
    public string Id { get; set; }
    private byte[] Payload { get; set; } = [];

    public int GetSize()
    {
        return Payload.Length;
    }
}