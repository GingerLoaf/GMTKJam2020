using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `Camera`. Inherits from `AtomVariable&lt;Camera, CameraPair, CameraEvent, CameraPairEvent, CameraCameraFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Camera", fileName = "CameraVariable")]
    public sealed class CameraVariable : AtomVariable<Camera, CameraPair, CameraEvent, CameraPairEvent, CameraCameraFunction>
    {
        protected override bool ValueEquals(Camera other)
        {
            throw new NotImplementedException();
        }
    }
}
