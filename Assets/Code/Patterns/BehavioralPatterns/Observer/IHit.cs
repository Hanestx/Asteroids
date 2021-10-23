using System;

namespace Code.Patterns.BehavioralPatterns.Observer
{
    public interface IHit
    {
        event Action<float> OnHitChange;
        void Hit(float damage);
    }
}