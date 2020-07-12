using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `Distraction`. Inherits from `AtomValueList&lt;Distraction, DistractionEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Distraction", fileName = "DistractionValueList")]
    public sealed class DistractionValueList : AtomValueList<Distraction, DistractionEvent> { }
}
