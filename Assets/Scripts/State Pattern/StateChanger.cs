using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace State_Pattern
{
    
    public class StateChanger : MonoBehaviour
    {
        private LocomotionStatePattern _states;

        private void Start()
        {
            _states = FindObjectOfType<LocomotionStatePattern>();
        }

        [Button]
        private void Crouch()
        {
            _states.Crouch();
        }
        [Button]
       private void Jump()
       {
           _states.Jump();
       }
       [Button]
       private void Land()
       {
           _states.Land();
       }
        
    }
}