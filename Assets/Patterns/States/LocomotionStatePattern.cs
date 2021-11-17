using State_Pattern;
using UnityEngine;

public interface ILocomotionContext
{
    void SetState(ILocomotionState newState);
}
public interface ILocomotionState
{
    void Jump(ILocomotionContext context);
    void Fall(ILocomotionContext context);
    void Land(ILocomotionContext context);
    void Crouch(ILocomotionContext context);
}
public class LocomotionStatePattern : MonoBehaviour, ILocomotionContext
{
    
    private ILocomotionState currentState = new GroundedState();

    public void Crouch() => currentState.Crouch(this);
    
    public void Fall() => currentState.Fall(this);

    public void Jump() => currentState.Jump(this);
    
    public void Land() => currentState.Land(this);
    
   
    void ILocomotionContext.SetState(ILocomotionState newState)
    {
        currentState = newState;
    }
}

