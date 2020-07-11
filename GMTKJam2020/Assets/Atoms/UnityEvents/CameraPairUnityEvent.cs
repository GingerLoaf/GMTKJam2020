using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `CameraPair`. Inherits from `UnityEvent&lt;CameraPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CameraPairUnityEvent : UnityEvent<CameraPair> { }
}
