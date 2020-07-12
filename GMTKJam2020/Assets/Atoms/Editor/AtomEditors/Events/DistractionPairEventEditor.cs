#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `DistractionPair`. Inherits from `AtomEventEditor&lt;DistractionPair, DistractionPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(DistractionPairEvent))]
    public sealed class DistractionPairEventEditor : AtomEventEditor<DistractionPair, DistractionPairEvent> { }
}
#endif
