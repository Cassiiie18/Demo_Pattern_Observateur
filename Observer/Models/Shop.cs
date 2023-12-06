using Observer.Interfaces;

namespace Observer.Models;

public class Shop : ISubject
{

    public Shop(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public Action<ISubject, EventArgs> ObserversDelegate { get; set; } = null;

    public void Attach(IObserver observer)
    {
        ObserversDelegate += observer.Update;
    }

    public void Detach(IObserver observer)
    {
        if (ObserversDelegate is not null)
        {
            ObserversDelegate -= observer.Update;
        }
    }

    public void Notify()
    {
        if (ObserversDelegate is not null)
        {
            ObserversDelegate.Invoke(this, new EventArgs());
        }
        
    }
}