using Project.CodeBase.Common;
using Project.CodeBase.Infrastructure.Services;
using UnityEngine;
namespace Project.CodeBase.Infrastructure {
    public class Container  : MonoBehaviour {
        public static Container Instance { get; private set;}
        
        private GameStateMachine.GameStateMachine _gameStateMachine;
        private InputService _inputService;
        private Factory _factory;
        private Timer _timer;
        public GameStateMachine.GameStateMachine GameStateMachine => _gameStateMachine;
        public InputService InputService => _inputService;
        public Factory Factory => _factory;
        public Timer Timer => _timer;

        private void Awake() { 
            
            Init();
            _gameStateMachine = new GameStateMachine.GameStateMachine();
            _inputService = new InputService();
            _factory = new Factory();
            _timer = new Timer();
        }

        private void Init() {
            if(Instance != null)
                Destroy(gameObject);
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }
}