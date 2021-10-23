using Code.Asteroids.Interfaces;
using UnityEngine;

namespace Code.Asteroids
{
    internal sealed class RotationShip : IRotation
    {
        private readonly Transform _transform;
        private Rigidbody2D _rigidbody;
        public float TurnSpeed { get; protected set; }
        
        public RotationShip(Rigidbody2D rigidbody2D, float turnSpeed)
        {
            _rigidbody = rigidbody2D;
            TurnSpeed = turnSpeed;
        }
        
        public void Rotation(float turnDirection)
        {
            var speed= TurnSpeed;
            _rigidbody.AddTorque(-turnDirection * speed);
        }
    }
}