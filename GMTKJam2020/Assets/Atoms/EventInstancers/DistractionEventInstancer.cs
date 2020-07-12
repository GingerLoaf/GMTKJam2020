using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `Distraction`. Inherits from `AtomEventInstancer&lt;Distraction, DistractionEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Distraction Event Instancer")]
    public class DistractionEventInstancer : AtomEventInstancer<Distraction, DistractionEvent> { }
}
