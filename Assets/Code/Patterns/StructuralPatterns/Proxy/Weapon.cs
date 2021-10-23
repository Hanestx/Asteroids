using UnityEngine;

namespace Code.Patterns.StructuralPatterns.Proxy
{
    public sealed class Weapon : IWeapon
    {
        public void Fire()
        {
            Debug.Log("Fire");
        }
    }
}