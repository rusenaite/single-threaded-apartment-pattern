namespace ApartmentArea;

public class Apartment
{
    public Apartment Instance;
    private readonly object _lock = new();

    private volatile int Area;

    public int GetArea()
    {
        lock (_lock)
        {
            return Area;
        }
    }

    public void UpdateArea(int setValue)
    {
        lock (_lock)
        {
            Interlocked.Exchange(ref Area, setValue);
        }
    }

    public Apartment()
    {
        Console.WriteLine("Apartment object " + Guid.NewGuid() + " was created.");
    }
    
    public void CreateApartmentObject()
    {
        Instance = new Apartment();
    }

    public void ThreadProcess()
    {
        Console.WriteLine("New Thread started.");
    }

}
