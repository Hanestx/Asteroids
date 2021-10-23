

using Code.Asteroids.Interfaces;

namespace Code.Asteroids
{
    internal sealed class Ship : IMove, IRotation, IShoot
    {
        private readonly IMove _moveImplementation;
        private readonly IRotation _rotationImplementation;
        private readonly IShoot _shootImplementation;
        private readonly IDamage _damageImplementation;

        public float Speed => _moveImplementation.Speed;

        
        public Ship(IMove moveImplementation, IRotation rotationImplementation, IShoot shootImplementation, IDamage damageImplementation)
        {
            _moveImplementation = moveImplementation;
            _rotationImplementation = rotationImplementation;
            _shootImplementation = shootImplementation;
            _damageImplementation = damageImplementation;
        }

        public void Move(float vertical)
        {
            _moveImplementation.Move(vertical);
        }

        public void Rotation(float direction)
        {
            _rotationImplementation.Rotation(direction);
        }

        public void Shoot()
        {
            _shootImplementation.Shoot();
        }

        public bool Damage()
        {
            return _damageImplementation.TakeDamage();
        }

        public void AddAcceleration()
        {
            if (_moveImplementation is AccelerationMove accelerationMove)
            {
                accelerationMove.AddAcceleration();
            }
        }

        public void RemoveAcceleration()
        {
            if (_moveImplementation is AccelerationMove accelerationMove)
            {
                accelerationMove.RemoveAcceleration();
            }
        }
    }
}