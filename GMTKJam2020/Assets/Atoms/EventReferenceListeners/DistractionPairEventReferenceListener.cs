using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `DistractionPair`. Inherits from `AtomEventReferenceListener&lt;DistractionPair, DistractionPairEvent, DistractionPairEventReference, DistractionPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/DistractionPair Event Reference Listener")]
    public sealed class DistractionPairEventReferenceListener : AtomEventReferenceListener<
        DistractionPair,
        DistractionPairEvent,
        DistractionPairEventReference,
        DistractionPairUnityEvent>
    { }
}
