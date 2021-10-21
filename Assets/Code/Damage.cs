using UnityEngine;


namespace Asteroids
{
    internal sealed class Damage
    {
        private float _hp;

        public Damage(float hp)
        {
            _hp = hp;
        }

        public bool TakeDamage()
        {
            _hp--;
            
            if (_hp <= 0)
            {
                return false;
            }
            return true;
        }
    }
}