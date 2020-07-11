using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `Camera`. Inherits from `SetVariableValue&lt;Camera, CameraPair, CameraVariable, CameraConstant, CameraReference, CameraEvent, CameraPairEvent, CameraVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Camera", fileName = "SetCameraVariableValue")]
    public sealed class SetCameraVariableValue : SetVariableValue<
        Camera,
        CameraPair,
        CameraVariable,
        CameraConstant,
        CameraReference,
        CameraEvent,
        CameraPairEvent,
        CameraCameraFunction,
        CameraVariableInstancer>
    { }
}
