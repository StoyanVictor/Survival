using UnityEngine;
namespace Project.CodeBase.Gameplay.Player {
    public class PlayerController : MonoBehaviour {

        [SerializeField] private CharacterController _controller;
        [SerializeField] private PlayerData _config;
        
        private IMovable _moveStrategy;
        private void Start() {
            _moveStrategy = new CasualMover(_controller,_config);
        }
        private void Update() {
            _moveStrategy.Move();
        }
    }
}