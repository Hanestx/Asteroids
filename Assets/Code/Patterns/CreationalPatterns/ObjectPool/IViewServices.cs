using UnityEngine;

namespace Asteroids
{
    internal interface IViewServices
    {
        void Instantiate(GameObject prefab);
        void Destroy(GameObject value);
    }
}