using System;
using System.Collections.Generic;

namespace Project.CodeBase.Infrastructure.GameStateMachine {
    public class GameStateMachine{
        
        private IGameState _currentState;
        private Dictionary<Type, IGameState> _gameStates;
        
        public GameStateMachine() {
            _gameStates = new Dictionary<Type, IGameState>() {
                [typeof(BootstrapState)] = new BootstrapState(this),
                [typeof(LoadingState)] = new LoadingState(this),
                [typeof(GamePlayState)] = new GamePlayState(),
            };
        }
        public void SwitchState<TState>() where TState: IGameState {
            if(_currentState != null) 
                _currentState.Exit();
            _currentState = _gameStates[typeof(TState)];
            _currentState?.Enter();
        }
    }
}