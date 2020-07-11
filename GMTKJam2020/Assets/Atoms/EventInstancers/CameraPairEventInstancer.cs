using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `CameraPair`. Inherits from `AtomEventInstancer&lt;CameraPair, CameraPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/CameraPair Event Instancer")]
    public class CameraPairEventInstancer : AtomEventInstancer<CameraPair, CameraPairEvent> { }
}
