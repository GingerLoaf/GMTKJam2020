#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Camera`. Inherits from `AtomDrawer&lt;CameraVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CameraVariable))]
    public class CameraVariableDrawer : VariableDrawer<CameraVariable> { }
}
#endif
