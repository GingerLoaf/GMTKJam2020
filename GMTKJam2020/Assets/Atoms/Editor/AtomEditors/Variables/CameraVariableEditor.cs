using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Camera`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(CameraVariable))]
    public sealed class CameraVariableEditor : AtomVariableEditor<Camera, CameraPair> { }
}
