using Code.Patterns.Interfaces;
using UnityEngine;


namespace Asteroids
{
    internal class MoveTransform : IMove
    {
        private readonly Transform _transform;
        private Rigidbody2D _rigidbody2D;
        
        public float Speed { get; protected set; }


        public MoveTransform(Transform transform, Rigidbody2D rigidbody2D, float speed)
        {
            _transform = transform;
            _rigidbody2D = rigidbody2D;
            Speed = speed;
        }

        public void Move(float vertical)
        {
            var speed = Speed;
            _rigidbody2D.AddForce(_transform.up * vertical * speed );
        }
    }
}