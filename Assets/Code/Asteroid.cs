using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Asteroids
{
    internal sealed class Asteroid : Enemy
    {
        [SerializeField] private Sprite[] _sprites;
        [SerializeField] private float _minSize = 0.5f;
        [SerializeField] private float _size = 1.0f;
        [SerializeField] private float _maxSize = 1.5f;
        [SerializeField] private float _speed = 10.0f;
        [SerializeField] private float _maxLifeTime = 30.0f;
        
        private SpriteRenderer _spriteRenderer;
        private Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            _size = Random.Range(_minSize, _maxSize);
            transform.eulerAngles = new Vector3(0.0f, 0.0f, Random.value * 360);
            transform.localScale = Vector3.one * _size;
            _spriteRenderer.sprite = _sprites[Random.Range(0, _sprites.Length)];
            _rigidbody2D.mass = _size;
            
        }


        public void SetTrajectory(Vector2 direction)
        {
            _rigidbody2D.AddForce(direction * _speed);
            Destroy(gameObject, _maxLifeTime);
        }
    }
}