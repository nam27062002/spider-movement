using StateMachines;
using UnityEngine;

namespace Enemies.Spiders
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
            Debug.Log($"Sprite state: {GetType().Name}");
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
