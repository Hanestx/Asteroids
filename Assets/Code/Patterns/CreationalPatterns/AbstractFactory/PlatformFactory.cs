using UnityEngine;

namespace Code.Patterns.CreationalPatterns.AbstractFactory
{
    internal sealed class PlatformFactory
    {
        private readonly InputFactory _inputFactory;
        private readonly WindowFactory _windowFactory;

        public PlatformFactory()
        {
            _inputFactory = new InputFactory();
            _windowFactory = new WindowFactory();
        }
        
        public Platform Create(RuntimePlatform platform)
        {
            return new Platform(_inputFactory.CreateInput(platform), _windowFactory.CreateWindow(platform));
        }
    }
}