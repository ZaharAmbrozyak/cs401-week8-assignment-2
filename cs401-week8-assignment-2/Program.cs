using System.Resources;

namespace cs401_week8_assignment_2;

class Program
{
    static void Main(string[] args)
    {
        var file1 = new FileResource("input.txt");
        var file2 = new FileResource("test.txt");
        var network1 = new NetworkResource("kse.test.ua");
        var network2 = new NetworkResource("ucu.test.ua");

        var manager = new ResourceManager<Resource>();
        
        manager.Add(file1);
        manager.Add(file2);
        manager.Add(network1);
        manager.Add(network2);
        
        manager.OpenAll();

        using (var newResource = new FileResource("data.txt"))
        {
            newResource.Open();
        }
        
        manager.CloseAll();
        
        
    }
}