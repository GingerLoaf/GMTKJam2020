using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Distraction`. Inherits from `AtomEventReference&lt;Distraction, DistractionVariable, DistractionEvent, DistractionVariableInstancer, DistractionEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class DistractionEventReference : AtomEventReference<
        Distraction,
        DistractionVariable,
        DistractionEvent,
        DistractionVariableInstancer,
        DistractionEventInstancer>, IGetEvent 
    { }
}
