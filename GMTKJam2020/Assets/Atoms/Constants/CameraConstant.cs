using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Constant of type `Camera`. Inherits from `AtomBaseVariable&lt;Camera&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Camera", fileName = "CameraConstant")]
    public sealed class CameraConstant : AtomBaseVariable<Camera> { }
}
