using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Distraction`. Inherits from `AtomReference&lt;Distraction, DistractionPair, DistractionConstant, DistractionVariable, DistractionEvent, DistractionPairEvent, DistractionDistractionFunction, DistractionVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class DistractionReference : AtomReference<
        Distraction,
        DistractionPair,
        DistractionConstant,
        DistractionVariable,
        DistractionEvent,
        DistractionPairEvent,
        DistractionDistractionFunction,
        DistractionVariableInstancer>, IEquatable<DistractionReference>
    {
        public DistractionReference() : base() { }
        public DistractionReference(Distraction value) : base(value) { }
        public bool Equals(DistractionReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Distraction other)
        {
            throw new NotImplementedException();
        } 
    }
}
