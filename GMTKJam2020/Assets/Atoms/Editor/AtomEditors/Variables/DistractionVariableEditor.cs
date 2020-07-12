using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Distraction`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(DistractionVariable))]
    public sealed class DistractionVariableEditor : AtomVariableEditor<Distraction, DistractionPair> { }
}
