using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `DistractionPair`. Inherits from `AtomEvent&lt;DistractionPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/DistractionPair", fileName = "DistractionPairEvent")]
    public sealed class DistractionPairEvent : AtomEvent<DistractionPair> { }
}
