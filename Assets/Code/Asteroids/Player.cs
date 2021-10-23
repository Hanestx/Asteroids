using System;
using Code.Asteroids.Interfaces;
using UnityEngine;

namespace Code.Asteroids
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
        
        private AmmoPool _ammoPool;
        private bool _isAlive = true;
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
            _damage = new Damage(_hp);
            _ship = new Ship(_moveTransform, _rotation, _shooting, _damage);
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
            if (other.gameObject.CompareTag("Asteroid"))
            {
                _rigidbody.velocity = Vector3.zero;
                _rigidbody.angularDrag = 0.0f;
                gameObject.SetActive(false);
                _isAlive = _ship.Damage();
                Invoke(nameof(Respawn), 3.0f);
            }

            if (!_isAlive)
            {
                GameOver();
            }
        }

        private void GameOver()
        {
            throw new NotImplementedException();
        }

        private void Respawn()
        {
            transform.position = Vector3.zero;
            gameObject.layer = LayerMask.NameToLayer("IgnoreCollisions");
            gameObject.SetActive(true);
            Invoke(nameof(TurnOnCollisions), 3.0f);
        }

        private void TurnOnCollisions()
        {
            gameObject.layer = LayerMask.NameToLayer("Player");
        }

        private void GetAxis()
        {
            _thrustDirection = Input.GetAxis("Vertical");
            _turnDirection = Input.GetAxis("Horizontal");
        }
    }
}