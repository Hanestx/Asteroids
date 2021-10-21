﻿namespace Code.Patterns.ChainOfResponsibility.First
{
    public interface IGameHandler
    {
        IGameHandler Handle();
        IGameHandler SetNext(IGameHandler nextHandler);
    }
}