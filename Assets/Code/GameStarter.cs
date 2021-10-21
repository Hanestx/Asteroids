﻿using Code.Patterns.ObjectPool;
using UnityEngine;

namespace Asteroids
{
    internal sealed class GameStarter : MonoBehaviour
    {
        private void Start()
        {
            //Фабричный метод
            
            // Enemy.CreateAsteroidEnemy(new Health(100.0f, 100.0f));
            // IEnemyFactory factory = new AsteroidFactory();
            // factory.Create(new Health(100.0f, 100.0f));
            // Enemy.Factory = factory;
            // Enemy.Factory.Create(new Health(100.0f, 100.0f));
            
            
            //PoolObject
            
            EnemyPool enemyPool = new EnemyPool(5);
            var enemy = enemyPool.GetEnemy("Asteroid");
            enemy.transform.position = Vector3.one;
            enemy.gameObject.SetActive(true);

        }
    }
}