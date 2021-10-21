using UnityEngine;

namespace Code.Patterns.Proxy
{
    public sealed class Weapon : IWeapon
    {
        public void Fire()
        {
            Debug.Log("Fire");
        }
    }
}