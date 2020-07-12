#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Distraction`. Inherits from `AtomDrawer&lt;DistractionConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(DistractionConstant))]
    public class DistractionConstantDrawer : VariableDrawer<DistractionConstant> { }
}
#endif
