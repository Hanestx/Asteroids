namespace Code.Patterns.AbstractFactory
{
    internal sealed class ConsoleInput : IInput
    {
        public string Name => nameof(ConsoleInput);
    }

}