﻿namespace Code.Patterns.AbstractFactory
{
    internal sealed class ConsoleWindow : IWindow
    {
        public string Name => nameof(ConsoleWindow);
    }
}