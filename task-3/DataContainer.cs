namespace task_3;

public class DataContainer<T> where T: DataItem
{
    private readonly List<T> _data = [];

    public void AddItem(T item)
    {
        _data.Add(item);
    }

    public long GetTotalSize()
    {
        var totalSize = 0;
        foreach (var item in _data)
        {
            totalSize += item.GetSize();
        }

        return totalSize;
    }
}