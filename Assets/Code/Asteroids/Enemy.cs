using Code.Asteroids.Interfaces;
using Code.Patterns.CreationalPatterns.ObjectPool;
using UnityEngine;

namespace Code.Asteroids
{
    internal abstract class Enemy : MonoBehaviour
    {
        public static IEnemyFactory Factory;
        private Transform _rootPool;
        private Health _health;
        public Health Health
        {
            get
            {
                if (_health.Current <= 0.0f)
                {
                    ReturnToPool();
                }
                return _health;
            }
            protected set => _health = value;
        }

        public Transform RootPool
        {
            get
            {if (_rootPool == null)
                {
                    var find = GameObject.Find(NameManager.POOL_AMMUNITION);
                    _rootPool = find == null ? null : find.transform;
                }

                return _rootPool;
            }
        }


        public static Asteroid CreateAsteroidEnemy(Health hp, Vector3 spawnPosition, Quaternion rotation)
        {
            var enemy = Instantiate(Resources.Load<Asteroid>("Enemy/Asteroid"), spawnPosition, rotation);
            enemy.Health = hp;
            enemy.SetSize();
            return enemy;
        }
        

        public static UFO CreateUFOEnemy(Health hp)
        {
            var enemy = Instantiate(Resources.Load<UFO>("Enemy/UFO"));
            enemy.Health = hp;
            return enemy;
        }
        public void DependencyInjectHealth(Health hp)
        {
            Health = hp;
        }
        
        public void ActiveEnemy(Vector3 position, Quaternion rotation)
        {
            transform.localPosition = position;
            transform.localRotation = rotation;
            gameObject.SetActive(true);
            transform.SetParent(null);
        }

        protected void ReturnToPool()
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            gameObject.SetActive(false);
            transform.SetParent(RootPool);

            if (!RootPool)
            {
                Destroy(gameObject);
            }
        }


    }
}