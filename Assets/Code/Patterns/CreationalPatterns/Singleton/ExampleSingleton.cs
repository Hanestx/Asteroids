using UnityEngine;

namespace Code.Patterns.Singleton
{
    internal sealed class ExampleSingleton : MonoBehaviour
    {
        private void Start()
        {
            Services.Instance.Test();
        }
    }
}