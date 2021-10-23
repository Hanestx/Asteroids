using UnityEngine;

namespace Code.Asteroids
{
    internal sealed class AsteroidSpawner : MonoBehaviour
    {
        [SerializeField] private float _spawnRate = 2.0f;
        [SerializeField] private float _spawnAmount = 1.0f;
        [SerializeField] private float _spawnDistance = 15.0f;
        [SerializeField] private float _trajectoryVariance = 15.0f;

        private void Start()
        {
            InvokeRepeating(nameof(Spawn), _spawnRate, _spawnRate);
        }

        private void Spawn()
        {
           
            for (int i = 0; i < _spawnAmount; i++)
            {
                Vector3 spawnDirection = Random.insideUnitCircle.normalized * _spawnDistance;
                Vector3 spawnPoint = transform.position + spawnDirection;
                
                float variance = Random.Range(-_trajectoryVariance, _trajectoryVariance);
                Quaternion rotation = Quaternion.AngleAxis(variance, Vector3.forward);
                
                Enemy.CreateAsteroidEnemy(new Health(50.0f, 50.0f), spawnPoint, rotation).
                    SetTrajectory(rotation * -spawnDirection);
            }
        }
    }
}