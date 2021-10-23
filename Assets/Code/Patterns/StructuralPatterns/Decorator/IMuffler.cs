using UnityEngine;

namespace Code.Patterns.StructuralPatterns.Decorator
{
    internal interface IMuffler
    {
        AudioClip AudioClipMuffler { get; }
        float VolumeFireOnMuffler { get; }
        Transform BarrelPositionMuffler { get; }
        GameObject MufflerInstance { get; }
    }
}