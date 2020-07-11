#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Camera`. Inherits from `AtomEventEditor&lt;Camera, CameraEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(CameraEvent))]
    public sealed class CameraEventEditor : AtomEventEditor<Camera, CameraEvent> { }
}
#endif
