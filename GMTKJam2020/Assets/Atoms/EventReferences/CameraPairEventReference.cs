using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `CameraPair`. Inherits from `AtomEventReference&lt;CameraPair, CameraVariable, CameraPairEvent, CameraVariableInstancer, CameraPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CameraPairEventReference : AtomEventReference<
        CameraPair,
        CameraVariable,
        CameraPairEvent,
        CameraVariableInstancer,
        CameraPairEventInstancer>, IGetEvent 
    { }
}
