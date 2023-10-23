using ScriptableObject.Enemies.Arachnid;
using UnityEngine;
namespace Enemies.Spiders
{
    public class Spider : MonoBehaviour
    {
        public SpiderDataConfigSo DataConfig;
        public Rigidbody Rigidbody;
        private SpiderMovementStateMachine stateMachine;

        private void Awake()
        {
            stateMachine = new SpiderMovementStateMachine(this);
        }
        private void Start()
        {
            stateMachine.ChangeState(SpiderState.Idling);
        }

        private void Update()
        {
            stateMachine.HandleInput();
            stateMachine.Update();
        }

        private void FixedUpdate()
        {
            stateMachine.PhysicsUpdate();
        }
    }
}
