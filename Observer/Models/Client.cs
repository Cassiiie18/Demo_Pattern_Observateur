using Observer.Interfaces;

namespace Observer.Models;

public class Client : IObserver
{

    public string Name { get; set; }

    public Client(string name)
    {
        Name = name;
    }

    public void Update(ISubject sender, EventArgs e)
    {

        if (sender is Shop shop)
        {
            Console.WriteLine($"Client {Name}, notifié par {shop.Name}");
        }
        else
        {
            Console.WriteLine($"Client {Name}, notifié par une origine inconnue");
        }
        
    }
}