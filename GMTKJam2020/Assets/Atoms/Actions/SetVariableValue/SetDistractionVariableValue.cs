using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `Distraction`. Inherits from `SetVariableValue&lt;Distraction, DistractionPair, DistractionVariable, DistractionConstant, DistractionReference, DistractionEvent, DistractionPairEvent, DistractionVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Distraction", fileName = "SetDistractionVariableValue")]
    public sealed class SetDistractionVariableValue : SetVariableValue<
        Distraction,
        DistractionPair,
        DistractionVariable,
        DistractionConstant,
        DistractionReference,
        DistractionEvent,
        DistractionPairEvent,
        DistractionDistractionFunction,
        DistractionVariableInstancer>
    { }
}
