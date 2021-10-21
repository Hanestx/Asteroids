using UnityEngine;


namespace Asteroids
{
    internal sealed class Shooting : MonoBehaviour, IShoot
    {
        private Bullet _bullet;
        private Transform _shootPoint;
        private float _forceBullet;

        public Shooting (Bullet bullet, Transform shootPoint)
        {
            _bullet = bullet;
            _shootPoint = shootPoint;
        }

        public void Shoot()
        {
            Bullet bullet = Instantiate(_bullet, _shootPoint.position, _shootPoint.rotation);
            bullet.Shoot(_shootPoint.up);
        }
    }
}