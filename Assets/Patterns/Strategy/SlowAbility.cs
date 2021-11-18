using UnityEngine;

namespace Patterns.Strategy
{
    public class SlowAbility : IAbility
    {
        public void Use(GameObject currentGameObject)
        {
            Debug.Log("Slow Down you peasant");
        }
    }
}