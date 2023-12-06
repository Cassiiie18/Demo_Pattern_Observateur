namespace Observer.Interfaces;

public interface IObserver
{
    public void Update(ISubject sender, EventArgs e);
}