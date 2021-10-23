﻿namespace Code.Patterns.BehavioralPatterns.Visitor
{
    public sealed class Enemy : Hit
    {
        public override void Activate(IDealingDamage value, float damage)
        {
            value.Visit(this, new InfoCollision(damage));
        }
    }
}