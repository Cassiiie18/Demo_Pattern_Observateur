namespace Observer.Interfaces;


public interface ISubject
{
    protected Action<ISubject, EventArgs> ObserversDelegate { get; set; }

    public void Attach(IObserver observer);

    public void Detach(IObserver observer);

    public void Notify();
}