using UnityEngine;

namespace Code.HomeworkNoNeed.BulletBuilder
{
    internal class BulletBuilder
    {
        protected GameObject _gameObject;

        public BulletBuilder() => _gameObject = new GameObject();
        protected BulletBuilder(GameObject gameObject) => _gameObject = gameObject;

        public BulletVisualBuilder Visual => new BulletVisualBuilder(_gameObject);
        public BulletPhysicsBuilder Physics => new BulletPhysicsBuilder(_gameObject);
        
        public static implicit operator GameObject(BulletBuilder builder)
        {
            return builder._gameObject;
        }

    }
}