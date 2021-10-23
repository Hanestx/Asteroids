using System.Collections.Generic;
using UnityEngine;

namespace Code.Patterns.CreationalPatterns.ObjectPool
{
    internal sealed class ViewServices : IViewServices
    {
        private readonly Dictionary<string, ObjectPool> _viewCache = new Dictionary<string, ObjectPool>(10);
        private IViewServices _viewServicesImplementation;


        public void Instantiate(GameObject prefab)
        {
            if (!_viewCache.TryGetValue(prefab.name, out ObjectPool viewPool))
            {
                viewPool = new ObjectPool(prefab);
                _viewCache[prefab.name] = viewPool;
            }

            viewPool.Pop();

        }
        

        public void Destroy(GameObject value)
        {
            _viewCache[value.name].Push(value);
        }
    }
}