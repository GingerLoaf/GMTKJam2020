#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Distraction`. Inherits from `AtomDrawer&lt;DistractionVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(DistractionVariable))]
    public class DistractionVariableDrawer : VariableDrawer<DistractionVariable> { }
}
#endif
