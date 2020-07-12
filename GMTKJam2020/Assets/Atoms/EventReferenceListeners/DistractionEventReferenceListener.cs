using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Distraction`. Inherits from `AtomEventReferenceListener&lt;Distraction, DistractionEvent, DistractionEventReference, DistractionUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Distraction Event Reference Listener")]
    public sealed class DistractionEventReferenceListener : AtomEventReferenceListener<
        Distraction,
        DistractionEvent,
        DistractionEventReference,
        DistractionUnityEvent>
    { }
}
