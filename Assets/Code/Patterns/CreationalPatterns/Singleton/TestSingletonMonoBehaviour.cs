using UnityEngine;

namespace Code.Patterns.Singleton
{
    internal sealed class TestSingletonMonoBehaviour : SingletonMonoBehaviour<TestSingletonMonoBehaviour>
    {
        public void Test()
        {
            Debug.Log(nameof(TestSingletonMonoBehaviour));
        }
    }
}