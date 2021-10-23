using UnityEngine;

namespace Code.Asteroids
{
    public class Star : MonoBehaviour
    {
        private float _size;
        private float _rangeSizeMin = 0.5f;
        private float _rangeSizeMax = 2.0f;
        private float _speed = 1.50f;
        private float _deadY = -8.0f;
        private MoveTransform _moveTransform;

        public float Speed => _speed;


        private void Start()
        {
            //_moveTransform = new MoveTransform(transform, Speed);
            _size = Random.Range(_rangeSizeMin, _rangeSizeMax);
            transform.localScale = new Vector3(_size, _size, _size);
        }

        /*void Update()
        {
            _moveTransform.Move(0.0f, Vector3.down.y, Time.deltaTime);

            if (transform.position.y < _deadY)
            {
                Destroy(gameObject);
            }
        }*/
        
    }
}