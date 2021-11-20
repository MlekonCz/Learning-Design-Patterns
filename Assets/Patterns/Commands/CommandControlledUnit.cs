﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

namespace Patterns.Commands
{
    public class CommandControlledUnit : MonoBehaviour
    {
        private NavMeshAgent _agent;
        
        private Queue<Command> _commands = new Queue<Command>();
        private Command _currentCommand;

        private void Start()
        {
            _agent = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {
            ListenForCommands();
            ProcessCommands();
        }
        private void ProcessCommands()
        {
            if (_currentCommand != null && _currentCommand.IsFinished == false) {return;}

            if (_commands.Any() == false){return;}

            _currentCommand = _commands.Dequeue();
            _currentCommand.Execute();
        }
        private void ListenForCommands()
        {
            if (Input.GetMouseButtonDown(0))
            {
                var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray,out var hitInfo))
                {
                    _commands.Enqueue(new MoveCommand(hitInfo.point, _agent));
                }
            }
        }
    }
}