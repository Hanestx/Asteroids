using System;
using UnityEngine;

namespace Asteroids.Patterns.NullObject
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