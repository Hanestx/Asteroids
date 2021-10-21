using UnityEngine;


namespace Asteroids
{
    internal sealed class Shooting : MonoBehaviour
    {
        private Rigidbody2D _bullet;
        private Transform _shootPoint;
        private float _forceBullet;

        public Shooting (Rigidbody2D bullet, Transform shootPoint, float forceBullet)
        {
            _bullet = bullet;
            _shootPoint = shootPoint;
            _forceBullet = forceBullet;
        }

        public void Shoot()
        {
            var temAmmunition = Instantiate(_bullet, _shootPoint.position, _shootPoint.rotation);
            temAmmunition.AddForce(_shootPoint.up * _forceBullet);
        }
    }
}