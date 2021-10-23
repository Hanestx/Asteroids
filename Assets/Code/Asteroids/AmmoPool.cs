using UnityEngine;

namespace Code.Asteroids
{
    internal sealed class AmmoPool
    {
        private int _poolCount;
        private bool _autoExpand;
        private Bullet _bulletPrefab;
        private readonly Transform _root;
        
        private PoolMono<Bullet> _pool;

        public AmmoPool(Bullet prefab, int poolCount, bool autoExpand)
        {
            _bulletPrefab = prefab;
            _poolCount = poolCount;
            _autoExpand = autoExpand;
            
            _root = new GameObject($"[{_bulletPrefab.name}]").transform;
            _pool = new PoolMono<Bullet>(_bulletPrefab, _poolCount, _root);
            _pool.AutoExpand = _autoExpand;
        }


        public void CreateBullet(Transform transformBullet)
        {
            Debug.Log("CreateBullet");
            var bullet = _pool.GetFreeElement();
            bullet.transform.position = transformBullet.position;
            bullet.transform.rotation = transformBullet.rotation;
            bullet.Shoot(transformBullet.up);
        }
    }
}