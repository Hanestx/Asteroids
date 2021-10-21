using UnityEngine;

namespace Asteroids.Patterns.BehaviorPatterns.Strategy
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