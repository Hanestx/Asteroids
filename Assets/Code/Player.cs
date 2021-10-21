using System;
using Code.Patterns.Interfaces;
using UnityEngine;


namespace Asteroids
{
    [RequireComponent(typeof(Rigidbody2D))]
    internal sealed class Player : MonoBehaviour
    {
        private Rigidbody2D _rigidbody;
        private float _thrustDirection;
        private float _turnDirection;
        [SerializeField] private float _thrustSpeed = 2;
        [SerializeField] private float _turnSpeed = 2;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _hp;

        [SerializeField] private Bullet _bullet;
        [SerializeField] private Transform _shootPoint;
        [SerializeField] private AmmoPool _ammoPool;
        
        private bool _isAlive;
        private IMove _moveTransform;
        private IRotation _rotation;
        private Camera _camera;
        private Damage _damage;
        private Shooting _shooting;
        private Ship _ship;


        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _ammoPool = new AmmoPool(_bullet, 5, true);
        }

        private void Start()
        {
            _camera = Camera.main;
            _moveTransform = new AccelerationMove(transform, _rigidbody, _thrustSpeed, _acceleration);
            _rotation = new RotationShip(_rigidbody, _turnSpeed);
            _shooting = new Shooting(_shootPoint, _ammoPool);
            _ship = new Ship(_moveTransform, _rotation, _shooting);
            _damage = new Damage(_hp);
        }

        private void Update()
        {
            GetAxis();

            if (Input.GetKeyDown(KeyCode.LeftShift))
                if (_moveTransform is AccelerationMove accelerationMove)
                    accelerationMove.AddAcceleration();

            if (Input.GetKeyUp(KeyCode.LeftShift))
                if (_moveTransform is AccelerationMove accelerationMove)
                    accelerationMove.RemoveAcceleration();

            if (Input.GetButtonDown("Fire1"))
                _ship.Shoot();
                //_ship.Shoot();
        }

        private void FixedUpdate()
        {
            _ship.Move(_thrustDirection);
            _ship.Rotation(_turnDirection);

        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            _isAlive = _damage.TakeDamage();

            if (!_isAlive)
                Destroy(gameObject);
        }

        private void GetAxis()
        {
            _thrustDirection = Input.GetAxis("Vertical");
            _turnDirection = Input.GetAxis("Horizontal");
        }
    }
}