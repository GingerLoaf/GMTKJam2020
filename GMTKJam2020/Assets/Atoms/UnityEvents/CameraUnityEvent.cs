using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Camera`. Inherits from `UnityEvent&lt;Camera&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CameraUnityEvent : UnityEvent<Camera> { }
}
