using System;
using UnityEngine;

namespace Patterns.Strategy
{
    // Composite Pattern
    public class SequenceComposite : IAbility
    {
        private IAbility[] _children;   
        
        public SequenceComposite(IAbility[] children)
        {
            this._children = children;
        }
        public void Use(GameObject currentGameObject)
        {
            foreach (var child in _children)
            {
                child.Use(currentGameObject);
            }
        }
    }
}