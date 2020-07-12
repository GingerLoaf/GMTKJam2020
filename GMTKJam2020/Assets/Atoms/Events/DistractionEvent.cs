using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Distraction`. Inherits from `AtomEvent&lt;Distraction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Distraction", fileName = "DistractionEvent")]
    public sealed class DistractionEvent : AtomEvent<Distraction> { }
}
