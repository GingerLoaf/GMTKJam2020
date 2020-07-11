using System;
using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;Camera&gt;`. Inherits from `IPair&lt;Camera&gt;`.
    /// </summary>
    [Serializable]
    public struct CameraPair : IPair<Camera>
    {
        public Camera Item1 { get => _item1; set => _item1 = value; }
        public Camera Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Camera _item1;
        [SerializeField]
        private Camera _item2;

        public void Deconstruct(out Camera item1, out Camera item2) { item1 = Item1; item2 = Item2; }
    }
}