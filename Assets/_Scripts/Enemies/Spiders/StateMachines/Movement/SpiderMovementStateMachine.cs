using Enemies.Spiders.StateMachines.Movement.States.Grounded.Moving;
using StateMachines;
using System.Collections.Generic;

namespace Enemies.Spiders
{
    public class SpiderMovementStateMachine : StateMachine
    {
        public readonly Spider Spider;
        private readonly SpiderIdlingState idlingState;
        private readonly SpiderRunningState runningState;

        private Dictionary<SpiderState, SpiderMovementState> spiderStates;

        public SpiderMovementStateMachine(Spider spider)
        {
            Spider = spider;
            
            idlingState = new SpiderIdlingState(this);
            runningState = new SpiderRunningState(this);

            spiderStates = new Dictionary<SpiderState, SpiderMovementState>
            {
                { SpiderState.Idling, idlingState },
                { SpiderState.Running, runningState }
            };
        }


        #region Main methods
        public void ChangeState(SpiderState state)
        {
            ChangeState(spiderStates[state]);
        }
        #endregion
    }
}
