using System;
using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;Distraction&gt;`. Inherits from `IPair&lt;Distraction&gt;`.
    /// </summary>
    [Serializable]
    public struct DistractionPair : IPair<Distraction>
    {
        public Distraction Item1 { get => _item1; set => _item1 = value; }
        public Distraction Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Distraction _item1;
        [SerializeField]
        private Distraction _item2;

        public void Deconstruct(out Distraction item1, out Distraction item2) { item1 = Item1; item2 = Item2; }
    }
}