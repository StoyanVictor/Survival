using Project.CodeBase.Infrastructure.Services;
using UnityEngine;
namespace Project.CodeBase.Infrastructure {
    public class Container  : MonoBehaviour {
        public static Container Instance { get; private set;}
        
        private GameStateMachine.GameStateMachine _gameStateMachine;
        private InputService _inputService;
        private Factory _factory;
        public GameStateMachine.GameStateMachine GameStateMachine => _gameStateMachine;
        public InputService InputService => _inputService;
        public Factory Factory => _factory;

        private void Awake() { 
            
            Init();
            _gameStateMachine = new GameStateMachine.GameStateMachine();
            _inputService = new InputService();
            _factory = new Factory();
        }

        private void Init() {
            if(Instance != null)
                Destroy(gameObject);
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }
}