using UnityEngine;

namespace Code.Patterns.BehavioralPatterns.State
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