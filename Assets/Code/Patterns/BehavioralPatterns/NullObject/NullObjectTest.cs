using System;
using UnityEngine;

namespace Code.Patterns.BehavioralPatterns.NullObject
{
    internal sealed class NullObjectTest : MonoBehaviour
    {
        public event Action Doing = () => { };
        
        private void Start()
        {
            Doing.Invoke();
            
            // Пример в паттерне команда класс DoNothing
        }
    }

}