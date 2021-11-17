using UnityEngine;

namespace State_Pattern
{
    public class InAirState : ILocomotionState
    {
        public void Land(ILocomotionContext context)
        {
            context.SetState(new GroundedState());
            Debug.Log("Iam Standing");
            
        }
        public void Jump(ILocomotionContext context)
        {
        }

        public void Fall(ILocomotionContext context)
        {
        }
        public void Crouch(ILocomotionContext context)
        {
        }
    }
}