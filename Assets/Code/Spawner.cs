using System;
using UnityEngine;
using Random = UnityEngine.Random;


namespace Asteroids
{
    public class Spawner : MonoBehaviour
    { 
        [SerializeField] private GameObject[] _spawnObjects;
        private GameObject _spawnObject;
        private float _rangePosX = 12.0f;
        private float _posX;
        private float _posZ = -5.0f;
        private float _timer = 0.0f;
        private float _cooldown = 0.50f;
        

        private void Update()
        {
            _timer += Time.deltaTime;
            
            if (_timer > _cooldown)
            {
                _timer = 0.0f;
                CreateObject();
            }
        }

        private void CreateObject()
        {
            _spawnObject = Instantiate(_spawnObjects[Random.Range(0, _spawnObjects.Length - 1)]);
            _posX = Random.Range(-_rangePosX, _rangePosX);
            _spawnObject.transform.position = transform.position + new Vector3(_posX, 0.0f,_posZ);
        }
    }
}