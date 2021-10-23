using UnityEngine;

namespace Code.HomeworkNoNeed.BulletBuilder
{
    internal sealed class BulletVisualBuilder : BulletBuilder
    {
        public BulletVisualBuilder(GameObject gameObject) : base(gameObject)
        {
        }

        public BulletVisualBuilder Name(string name)
        {
            _gameObject.name = name;
            return this;
        }

        public BulletVisualBuilder Sprite(Sprite sprite)
        {
            var component = GetOrAddComponent<SpriteRenderer>();
            component.sprite = sprite;
            return this;
        }

        private T GetOrAddComponent<T>() where T : Component
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