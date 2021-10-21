using UnityEngine;

namespace Asteroids
{
    internal sealed class BulletPhysicsBuilder : BulletBuilder
    {
        public BulletPhysicsBuilder(GameObject gameObject) : base(gameObject) {}

        public BulletBuilder BoxCollider2D()
        {
            GetOrAddComponent<BoxCollider2D>();
            return this;
        }
        
        public BulletPhysicsBuilder Rigidbody2D(float mass)
        {
            var component = GetOrAddComponent<Rigidbody2D>();
            component.mass = mass;
            component.angularDrag = 0;
            component.drag = 0;
            component.gravityScale = 0;
            return this;
        }

        public T GetOrAddComponent<T>() where T : Component
        {
            var result = _gameObject.GetComponent<T>();
            if (!result)
            {
                result = _gameObject.AddComponent<T>();
            }
            return result;
        }
    }


}