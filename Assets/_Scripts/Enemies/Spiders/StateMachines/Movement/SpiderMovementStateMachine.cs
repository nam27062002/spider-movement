using StateMachines;

namespace Enemies.Spiders.StateMachines.Movement
{
    
    public class SpiderMovementStateMachine : StateMachine
    {
        public readonly Spider Spider;
        public SpiderMovementStateMachine(Spider spider)
        {
            Spider = spider;
            
        }
    }
}
