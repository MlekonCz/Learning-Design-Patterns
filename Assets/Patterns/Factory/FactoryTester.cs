using Sirenix.OdinInspector;
using UnityEngine;

namespace Patterns.Factory
{
    public class FactoryTester : MonoBehaviour
    {

        [Button]
        void CastFireBall()
        {
            AbilityFactory.GetAbility("Fire").Process();
        }
        [Button]
        void CastHeal()
        {
            AbilityFactory.GetAbility("Heal").Process();
        }
    }
}