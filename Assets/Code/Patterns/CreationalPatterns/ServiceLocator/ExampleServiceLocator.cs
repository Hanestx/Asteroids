using UnityEngine;

namespace Code.Patterns.CreationalPatterns.ServiceLocator
{
    internal sealed class ExampleServiceLocator : MonoBehaviour
    {
        private void Awake()
        {
            ServiceLocator.SetService<IService>(new Service());
        }

        private void Start()
        {
            ServiceLocator.Resolve<IService>().Test();
        }
    }
}