using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `Camera`. Inherits from `AtomValueList&lt;Camera, CameraEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Camera", fileName = "CameraValueList")]
    public sealed class CameraValueList : AtomValueList<Camera, CameraEvent> { }
}
