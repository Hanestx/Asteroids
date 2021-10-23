using UnityEngine;

namespace Code.Patterns.StructuralPatterns.Adapter
{
    public interface IAttack
    {
        void Attack(Vector3 position);
    }
}