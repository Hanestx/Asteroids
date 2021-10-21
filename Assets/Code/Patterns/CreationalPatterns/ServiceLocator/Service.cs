using UnityEngine;

namespace Code.Patterns.ServiceLocator
{
    internal sealed class Service : IService
    {
        public void Test()
        {
            Debug.Log(nameof(Service));
        }
    }
}