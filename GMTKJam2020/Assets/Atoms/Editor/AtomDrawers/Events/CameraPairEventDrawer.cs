#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `CameraPair`. Inherits from `AtomDrawer&lt;CameraPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CameraPairEvent))]
    public class CameraPairEventDrawer : AtomDrawer<CameraPairEvent> { }
}
#endif
