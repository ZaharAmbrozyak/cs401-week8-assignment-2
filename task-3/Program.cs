namespace task_3;

class Program
{
    static void Main(string[] args)
    {
        var dataContainer = new DataContainer<DataItem>();
        
        for (var i = 0; i < 10000; i++)
        {
            var item = new DataItem()
            {
                Id = $"item-{i}",
                Payload = new byte[1024]
            };
            dataContainer.AddItem(item);
        }
        
        Console.WriteLine($"Total size before GC: {dataContainer.GetTotalSize()} bytes");
        
        GC.Collect();
        
        Console.WriteLine("GC.Collect() was called");
        Console.WriteLine($"Total size after GC: {dataContainer.GetTotalSize()} bytes");
        
        Console.WriteLine("Розмір залишається тим же самим, оскільки ми додали всі ці об'єкти у List і вони зберігаються в оперативній памяті ");
        Console.WriteLine("Після GC.Collect() ми маємо прибрати всі об'єкти , які не використовуються, але таких в програмі немає, бо змінна dataContainer ще активна");
    }
}