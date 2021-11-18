using UnityEngine;

namespace Patterns.Strategy
{
    // Decorator Pattern
    public class DelayedDecorator: IAbility
    {
        private IAbility wrappedAbility;

        public DelayedDecorator(IAbility wrappedAbility)
        {
            this.wrappedAbility = wrappedAbility;
        }

        public void Use(GameObject currentGameObject)
        {
            wrappedAbility.Use(currentGameObject);
        }
    }
}