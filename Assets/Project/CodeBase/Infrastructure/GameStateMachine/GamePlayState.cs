using UnityEngine;

namespace Project.CodeBase.Infrastructure.GameStateMachine {
    public class GamePlayState : IGameState {
        public void Enter() {
            Debug.Log("Game");
        }
        public void Exit() {
        }
        public void Execute() {
        }
    }
}