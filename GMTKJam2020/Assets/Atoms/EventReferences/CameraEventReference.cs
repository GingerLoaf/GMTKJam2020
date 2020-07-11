using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Camera`. Inherits from `AtomEventReference&lt;Camera, CameraVariable, CameraEvent, CameraVariableInstancer, CameraEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CameraEventReference : AtomEventReference<
        Camera,
        CameraVariable,
        CameraEvent,
        CameraVariableInstancer,
        CameraEventInstancer>, IGetEvent 
    { }
}
