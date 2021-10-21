using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _speed = 500.0f;
    private float _maxLifeTime = 10.0f;
    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Shoot(Vector2 direction)
    {
       _rigidbody2D.AddForce(direction * _speed); 
       Destroy(gameObject, _maxLifeTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}
