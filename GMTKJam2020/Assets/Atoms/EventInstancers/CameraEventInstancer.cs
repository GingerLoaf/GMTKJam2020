using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `Camera`. Inherits from `AtomEventInstancer&lt;Camera, CameraEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Camera Event Instancer")]
    public class CameraEventInstancer : AtomEventInstancer<Camera, CameraEvent> { }
}
