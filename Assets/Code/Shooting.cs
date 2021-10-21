using System;
using UnityEngine;


namespace Asteroids
{
    internal sealed class Shooting : MonoBehaviour, IShoot
    {
        private Transform _shootPoint;
        private AmmoPool _bulletPool;
        private float _forceBullet;

        public Shooting (Transform shootPoint, AmmoPool pool)
        {
            _shootPoint = shootPoint;
            _bulletPool = pool;
        }

        public void Shoot()
        {
            _bulletPool.CreateBullet(_shootPoint);
        }
    }
}