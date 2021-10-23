using System;
using Code.Patterns.MVVM.Model;

namespace Code.Patterns.MVVM.ViewModel
{
    public interface IHpViewModel
    {
        IHpModel HpModel { get; }
        bool IsDead { get; }
        void ApplyDamage(float damage);
        event Action<float> OnHpChange;
    }
}