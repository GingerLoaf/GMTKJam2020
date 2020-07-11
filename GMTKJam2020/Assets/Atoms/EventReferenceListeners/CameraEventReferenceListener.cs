using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Camera`. Inherits from `AtomEventReferenceListener&lt;Camera, CameraEvent, CameraEventReference, CameraUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Camera Event Reference Listener")]
    public sealed class CameraEventReferenceListener : AtomEventReferenceListener<
        Camera,
        CameraEvent,
        CameraEventReference,
        CameraUnityEvent>
    { }
}
