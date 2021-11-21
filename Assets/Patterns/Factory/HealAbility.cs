using UnityEngine;

namespace Patterns.Factory
{
    public class HealAbility: Ability
    {
        public override string Name => "Heal";
        
        public override void Process()
        {
            Debug.Log("Let me heal you!");
        }
    }
}