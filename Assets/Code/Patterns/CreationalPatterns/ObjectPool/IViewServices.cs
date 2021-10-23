using UnityEngine;

namespace Code.Patterns.CreationalPatterns.ObjectPool
{
    internal interface IViewServices
    {
        void Instantiate(GameObject prefab);
        void Destroy(GameObject value);
    }
}