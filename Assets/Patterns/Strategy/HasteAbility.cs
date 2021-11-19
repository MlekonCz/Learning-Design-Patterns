using UnityEngine;

namespace Patterns.Strategy
{
    public class HasteAbility: IAbility
    {
        public void Use(GameObject currentGameObject)
        {
            Debug.Log("Fast as Fu** Boi");
        }
    }
}