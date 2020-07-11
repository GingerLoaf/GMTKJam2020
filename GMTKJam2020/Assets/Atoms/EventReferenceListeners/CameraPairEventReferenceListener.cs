using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `CameraPair`. Inherits from `AtomEventReferenceListener&lt;CameraPair, CameraPairEvent, CameraPairEventReference, CameraPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/CameraPair Event Reference Listener")]
    public sealed class CameraPairEventReferenceListener : AtomEventReferenceListener<
        CameraPair,
        CameraPairEvent,
        CameraPairEventReference,
        CameraPairUnityEvent>
    { }
}
