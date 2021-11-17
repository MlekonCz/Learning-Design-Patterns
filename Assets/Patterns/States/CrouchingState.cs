using UnityEngine;

namespace State_Pattern
{
    public class CrouchingState : ILocomotionState
    {
        public void Jump(ILocomotionContext context)
        {
            context.SetState(new GroundedState());
            Debug.Log("Iam Standing");
        }
        public void Fall(ILocomotionContext context)
        {
            context.SetState(new InAirState());
            Debug.Log("Iam inAir");
        }
        public void Land(ILocomotionContext context)
        {
        }
        public void Crouch(ILocomotionContext context)
        {
            context.SetState(new GroundedState());
            Debug.Log("Iam Standing");
        }
    }
}