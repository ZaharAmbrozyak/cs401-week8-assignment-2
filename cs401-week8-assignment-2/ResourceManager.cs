namespace cs401_week8_assignment_2;

public class ResourceManager<T> where T : Resource
{
    private readonly List<T> resources = [];

    public void Add(T resource)
    {
        resources.Add(resource);
    }

    public void OpenAll()
    {
        foreach (var resource in resources)
        {
            resource.Open();
        }
    }

    public void CloseAll()
    {
        foreach (var resource in resources)
        {
            resource.Close();
        }
    }
}