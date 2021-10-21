using Code.Patterns.Interfaces;
using UnityEngine;

namespace Asteroids
{
    internal sealed class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _forceBullet;
        [SerializeField] private float _hp;
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private Transform _shootPoint;
        private bool _isAlive;
        private IMove _moveTransform;
        private IRotation _rotation;
        private Camera _camera;
        private Damage _damage;
        private Shooting _shooting;
        private Ship _ship;


        private void Start()
        {
            _camera = Camera.main;
            _moveTransform = new AccelerationMove(transform, _speed, _acceleration);
            _rotation = new RotationShip(transform);
            _ship = new Ship(_moveTransform, _rotation);
            _shooting = new Shooting(_bullet, _shootPoint, _forceBullet);
            _damage = new Damage(_hp);
        }

        private void Update()
        {
            var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            _ship.Rotation(direction);

            _ship.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _ship.AddAcceleration();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _ship.RemoveAcceleration();
            }

            
            if (Input.GetButtonDown("Fire1"))
            {
                _shooting.Shoot();
            }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            _isAlive = _damage.TakeDamage();

            if (!_isAlive)
            {
                Destroy(gameObject);
            }
        }
    }
}