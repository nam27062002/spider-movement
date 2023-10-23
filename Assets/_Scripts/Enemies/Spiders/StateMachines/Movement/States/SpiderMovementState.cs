using StateMachines;

namespace Enemies.Spiders.StateMachines.Movement.States
{
    public class SpiderMovementState : IState
    {
        protected readonly SpiderMovementStateMachine StateMachine;
        public SpiderMovementState(SpiderMovementStateMachine stateMachine)
        {
            StateMachine = stateMachine;
        }

        #region IState Methods
        public void Enter()
        {
            
        }
        public void Exit()
        {
            
        }
        public void HandleInput()
        {
            
        }
        public void Update()
        {
            
        }
        public void PhysicsUpdate()
        {
            
        }
        #endregion
        
    }
}
