using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `CameraPair`. Inherits from `AtomEvent&lt;CameraPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/CameraPair", fileName = "CameraPairEvent")]
    public sealed class CameraPairEvent : AtomEvent<CameraPair> { }
}
