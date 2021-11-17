using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocomotionFSM : MonoBehaviour
{
    enum State
    {
        Grounded,
        InAir,
        Crouching
    }

    private State _currentState = State.Grounded;

    public void Jump()
    {
        switch (_currentState)
        {
            case State.Grounded:
                _currentState = State.InAir;
                break;
            case State.Crouching:
                _currentState = State.Grounded;
                break;
        }    
    }

    public void Fall()
    {
        switch (_currentState)
        {
            case State.Grounded:
                _currentState = State.InAir;
                break;
            case State.Crouching:
                _currentState = State.InAir;
                break;
        }
    }

    public void Land()
    {
        switch (_currentState)
        {
            case State.InAir:
                _currentState = State.Grounded;
                break;
        }
    }

    public void Crouch()
    {
        switch (_currentState)
        {
            case State.Grounded:
                _currentState = State.Crouching;
                break;
            case State.Crouching:
                _currentState = State.Grounded;
                break;
        }
    }
    
}
