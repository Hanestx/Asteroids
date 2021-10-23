using UnityEngine;

namespace Code.Patterns.BehavioralPatterns.Strategy
{
    public sealed class StrategyTest : MonoBehaviour
    { 
        [SerializeField] private BaseBehaviour _behaviour;
        private void Update()
        {
            _behaviour.Behaviour(transform);
        }
    }

}