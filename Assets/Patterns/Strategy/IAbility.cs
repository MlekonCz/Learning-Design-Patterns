using UnityEngine;

namespace Patterns.Strategy
{
    public interface IAbility
    {
        void Use(GameObject currentGameObject);
    }
}