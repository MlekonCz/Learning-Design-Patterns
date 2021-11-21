using UnityEngine;

namespace Patterns.Factory
{
    public class FireBallAbility : Ability
    {
        public override string Name => "Fire";
        
        public override void Process()
        {
            Debug.Log("I CAST FIRE BALL!!!!");
        }
    }
}