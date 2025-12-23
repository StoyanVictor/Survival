using UnityEngine;

namespace Project.CodeBase.Infrastructure.GameStateMachine
{
    public class BootstrapState : IGameState {
        private GameStateMachine _stateMachine;
        public BootstrapState(GameStateMachine gameStateMachine) {
            _stateMachine = gameStateMachine;
        }

        public void Enter() {
            Debug.Log("Booting");
            _stateMachine.SwitchState<LoadingState>();
        }
        public void Exit() {
        }
        public void Execute() {
        }
    }
}