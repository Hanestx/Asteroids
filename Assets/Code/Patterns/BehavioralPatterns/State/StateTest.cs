using UnityEngine;

namespace Asteroids.Patterns.BehaviorPatterns.State
{
    public sealed class StateTest : MonoBehaviour
    {
        private void Start()
        {
            Context c = new Context(new ConcreteStateA());

            c.Request();
            c.Request();
            c.Request();
            c.Request();
        }
    }
}