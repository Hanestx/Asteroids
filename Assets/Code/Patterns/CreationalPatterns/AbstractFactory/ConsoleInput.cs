namespace Code.Patterns.CreationalPatterns.AbstractFactory
{
    internal sealed class ConsoleInput : IInput
    {
        public string Name => nameof(ConsoleInput);
    }

}