using UnityEngine;

namespace Code.Patterns.Decorator
{
    internal interface IAmmunition
    {
        Rigidbody BulletInstance { get; }
        float TimeToDestroy { get; }
    }
}