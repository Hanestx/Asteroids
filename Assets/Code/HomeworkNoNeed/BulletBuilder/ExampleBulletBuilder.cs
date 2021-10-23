using Code.Asteroids;
using UnityEngine;

namespace Code.HomeworkNoNeed.BulletBuilder
{
    internal sealed class ExampleBulletBuilder : MonoBehaviour
    {
        [SerializeField] private Sprite _sprite;
        
        private void Start()
        {
            var BulletBuilder = new BulletBuilder();

            GameObject bullet = BulletBuilder.Visual.Name("Bullet").Sprite(_sprite).Physics.Rigidbody2D(1).BoxCollider2D();
            bullet.AddComponent<Bullet>();
            bullet.SetActive(true);
        }
        
    }

}