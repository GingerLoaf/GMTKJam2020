using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Camera`. Inherits from `AtomEvent&lt;Camera&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Camera", fileName = "CameraEvent")]
    public sealed class CameraEvent : AtomEvent<Camera> { }
}
