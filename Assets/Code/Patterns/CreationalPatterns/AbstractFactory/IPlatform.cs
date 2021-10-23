namespace Code.Patterns.CreationalPatterns.AbstractFactory
{
    public interface IPlatform
    {
        IInput Input { get; }
        IWindow Window { get; }
    }
}