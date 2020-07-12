using UnityEngine;
using System;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `Distraction`. Inherits from `AtomVariable&lt;Distraction, DistractionPair, DistractionEvent, DistractionPairEvent, DistractionDistractionFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Distraction", fileName = "DistractionVariable")]
    public sealed class DistractionVariable : AtomVariable<Distraction, DistractionPair, DistractionEvent, DistractionPairEvent, DistractionDistractionFunction>
    {
        protected override bool ValueEquals(Distraction other)
        {
            throw new NotImplementedException();
        }
    }
}
