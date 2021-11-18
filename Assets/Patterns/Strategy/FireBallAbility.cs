using UnityEngine;

namespace Patterns.Strategy
{
    public class FireBallAbility: IAbility
    {
        public void Use(GameObject currentGameObject)
        {
            Debug.Log("I cast FIREBALL");
        }
    }
}