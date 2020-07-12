#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `DistractionPair`. Inherits from `AtomDrawer&lt;DistractionPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(DistractionPairEvent))]
    public class DistractionPairEventDrawer : AtomDrawer<DistractionPairEvent> { }
}
#endif
