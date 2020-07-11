using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `Camera`. Inherits from `AtomVariableInstancer&lt;CameraVariable, CameraPair, Camera, CameraEvent, CameraPairEvent, CameraCameraFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Camera Variable Instancer")]
    public class CameraVariableInstancer : AtomVariableInstancer<
        CameraVariable,
        CameraPair,
        Camera,
        CameraEvent,
        CameraPairEvent,
        CameraCameraFunction>
    { }
}
