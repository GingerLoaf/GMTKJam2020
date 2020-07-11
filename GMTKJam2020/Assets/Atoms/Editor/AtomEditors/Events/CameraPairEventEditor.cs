#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `CameraPair`. Inherits from `AtomEventEditor&lt;CameraPair, CameraPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(CameraPairEvent))]
    public sealed class CameraPairEventEditor : AtomEventEditor<CameraPair, CameraPairEvent> { }
}
#endif
