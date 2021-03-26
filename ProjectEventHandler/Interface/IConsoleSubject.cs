namespace ConsoleEventHandler.Interface
{
    public interface IConsoleSubject
    {
        void Attach(IConsoleObserver observer);
        void Detach(IConsoleObserver observer);
        void Notify();

    }
}
