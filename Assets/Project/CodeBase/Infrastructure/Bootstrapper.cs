using Project.CodeBase.Infrastructure.GameStateMachine;
using UnityEngine;
namespace Project.CodeBase.Infrastructure {
    public class Bootstrapper : MonoBehaviour {
        private void Start() {
            
            Container.Instance.GameStateMachine.SwitchState<BootstrapState>();
        }
    }
}