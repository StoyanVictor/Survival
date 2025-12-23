namespace Project.CodeBase.Infrastructure.GameStateMachine {
    public interface IGameState {
        public void Enter();
        public void Exit();
        public void Execute();
    }
}