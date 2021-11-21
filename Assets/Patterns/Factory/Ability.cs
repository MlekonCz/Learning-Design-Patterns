﻿namespace Patterns.Factory
{
    public abstract class Ability
    {
        public abstract string Name { get; }
        public abstract void Process();
    }
}