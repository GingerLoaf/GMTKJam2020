using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `Distraction`. Inherits from `AtomVariableInstancer&lt;DistractionVariable, DistractionPair, Distraction, DistractionEvent, DistractionPairEvent, DistractionDistractionFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Distraction Variable Instancer")]
    public class DistractionVariableInstancer : AtomVariableInstancer<
        DistractionVariable,
        DistractionPair,
        Distraction,
        DistractionEvent,
        DistractionPairEvent,
        DistractionDistractionFunction>
    { }
}
