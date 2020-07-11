#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Camera`. Inherits from `AtomDrawer&lt;CameraValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CameraValueList))]
    public class CameraValueListDrawer : AtomDrawer<CameraValueList> { }
}
#endif
