using Sirenix.OdinInspector;
using UnityEngine;

namespace Patterns.Strategy
{
    public class AbilityUser : MonoBehaviour
    {
        
        [SerializeField] private IAbility currentAbility = new FireBallAbility();

        [Button]
        public void UseAbility()
        {
            currentAbility.Use(gameObject);
            currentAbility = new SlowAbility();
        }
    }
}
