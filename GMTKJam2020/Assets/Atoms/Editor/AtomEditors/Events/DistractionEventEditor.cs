#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Distraction`. Inherits from `AtomEventEditor&lt;Distraction, DistractionEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(DistractionEvent))]
    public sealed class DistractionEventEditor : AtomEventEditor<Distraction, DistractionEvent> { }
}
#endif
