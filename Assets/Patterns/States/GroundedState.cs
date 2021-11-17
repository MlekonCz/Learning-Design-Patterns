using UnityEngine;

namespace State_Pattern
{
    public class GroundedState : ILocomotionState
    {
        public void Jump(ILocomotionContext context)
        {
            context.SetState(new InAirState());
            Debug.Log("Iam inAir");
        }
        public void Fall(ILocomotionContext context)
        {
            context.SetState(new InAirState());
            Debug.Log("Iam inAir");
        }
        public void Crouch(ILocomotionContext context)
        {
            context.SetState(new CrouchingState());
            Debug.Log("Iam Crouching");
        }
        public void Land(ILocomotionContext context)
        {
        }
    }
}