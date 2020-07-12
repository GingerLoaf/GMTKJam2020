using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `DistractionPair`. Inherits from `AtomEventReference&lt;DistractionPair, DistractionVariable, DistractionPairEvent, DistractionVariableInstancer, DistractionPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class DistractionPairEventReference : AtomEventReference<
        DistractionPair,
        DistractionVariable,
        DistractionPairEvent,
        DistractionVariableInstancer,
        DistractionPairEventInstancer>, IGetEvent 
    { }
}
