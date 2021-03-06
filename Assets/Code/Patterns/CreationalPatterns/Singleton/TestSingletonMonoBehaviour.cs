using UnityEngine;

namespace Code.Patterns.CreationalPatterns.Singleton
{
    internal sealed class TestSingletonMonoBehaviour : SingletonMonoBehaviour<TestSingletonMonoBehaviour>
    {
        public void Test()
        {
            Debug.Log(nameof(TestSingletonMonoBehaviour));
        }
    }
}