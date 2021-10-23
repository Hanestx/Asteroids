using UnityEngine;

namespace Code.Patterns.StructuralPatterns.Decorator
{
    internal interface IAmmunition
    {
        Rigidbody BulletInstance { get; }
        float TimeToDestroy { get; }
    }
}