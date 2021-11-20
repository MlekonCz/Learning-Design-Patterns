using UnityEngine;
using UnityEngine.AI;

namespace Patterns.Commands
{
    public class MoveCommand : Command
    {
        private readonly Vector3 _destination;
        private readonly NavMeshAgent _agent;

        public MoveCommand(Vector3 destination, NavMeshAgent _agent)
        {
            _destination = destination;
            this._agent = _agent;
        }
        public override void Execute()
        {
            _agent.SetDestination(_destination);
        }

        public override bool IsFinished
        {
            get { return _agent.remainingDistance <= 0.1f; }
        }
    }
}