using UnityEngine;

namespace Code.Patterns.Command.Second
{
    internal abstract class BaseUI : MonoBehaviour
    {
        public abstract void Execute();  
        public abstract void Cancel();
        //public abstract void Repeat();
        //....
    }
}