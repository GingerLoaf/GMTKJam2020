using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Camera`. Inherits from `AtomReference&lt;Camera, CameraPair, CameraConstant, CameraVariable, CameraEvent, CameraPairEvent, CameraCameraFunction, CameraVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CameraReference : AtomReference<
        Camera,
        CameraPair,
        CameraConstant,
        CameraVariable,
        CameraEvent,
        CameraPairEvent,
        CameraCameraFunction,
        CameraVariableInstancer>, IEquatable<CameraReference>
    {
        public CameraReference() : base() { }
        public CameraReference(Camera value) : base(value) { }
        public bool Equals(CameraReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Camera other)
        {
            throw new NotImplementedException();
        } 
    }
}
