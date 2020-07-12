#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Distraction`. Inherits from `AtomDrawer&lt;DistractionValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(DistractionValueList))]
    public class DistractionValueListDrawer : AtomDrawer<DistractionValueList> { }
}
#endif
