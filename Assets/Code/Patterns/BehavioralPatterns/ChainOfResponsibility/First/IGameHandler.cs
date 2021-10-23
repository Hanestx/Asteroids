namespace Code.Patterns.BehavioralPatterns.ChainOfResponsibility.First
{
    public interface IGameHandler
    {
        IGameHandler Handle();
        IGameHandler SetNext(IGameHandler nextHandler);
    }
}