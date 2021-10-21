using System;

namespace Asteroids.Patterns.Observer
{
    public interface IHit
    {
        event Action<float> OnHitChange;
        void Hit(float damage);
    }
}