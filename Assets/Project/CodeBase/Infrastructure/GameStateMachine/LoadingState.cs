using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Project.CodeBase.Infrastructure.GameStateMachine {
    public class LoadingState : IGameState {
        
        private GameStateMachine _stateMachine;
        public LoadingState(GameStateMachine gameStateMachine) {
            _stateMachine = gameStateMachine;
        }
        public async void Enter() { 
           await LoadGamePlay();
           _stateMachine.SwitchState<GamePlayState>();
        }
        private async Task LoadGamePlay() {
            var loadOperation = SceneManager.LoadSceneAsync(1);
            while (!loadOperation.isDone) {
                Debug.Log($"Loading: {loadOperation.progress * 100}%");
                await Task.Yield(); // 🔹 ждем кадр, чтобы Unity успела продолжить загрузку
            }
        }
        public void Exit() {
        }
        public void Execute() {
        }
    }
}