using UnityEngine;

namespace Code.Patterns.CreationalPatterns.Singleton
{
    internal sealed class ExampleSingleton : MonoBehaviour
    {
        private void Start()
        {
            Services.Instance.Test();
        }
    }
}