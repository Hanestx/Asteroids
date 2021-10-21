namespace Code.Patterns.AbstractFactory
{
    public interface IPlatform
    {
        IInput Input { get; }
        IWindow Window { get; }
    }
}