#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Camera`. Inherits from `AtomDrawer&lt;CameraConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CameraConstant))]
    public class CameraConstantDrawer : VariableDrawer<CameraConstant> { }
}
#endif
