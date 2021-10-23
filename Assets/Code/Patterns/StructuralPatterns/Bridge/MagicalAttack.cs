﻿namespace Code.Patterns.StructuralPatterns.Bridge
{
    internal sealed class MagicalAttack : IAttack
    {
        public void Attack()
        {
            throw new System.NotImplementedException();
        }
    }
}