#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Camera`. Inherits from `AtomDrawer&lt;CameraEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CameraEvent))]
    public class CameraEventDrawer : AtomDrawer<CameraEvent> { }
}
#endif
