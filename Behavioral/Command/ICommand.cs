﻿namespace QuattroDesignPatterns.Behavioral.Command
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}