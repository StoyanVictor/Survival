using System;
using System.Collections.Generic;
using Project.CodeBase.Gameplay.Player;
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

public class PlayerStateSwitcher {
    
    private Dictionary<PlayerStates, IMovable> _moveStrategies = new Dictionary<PlayerStates, IMovable>();
    public Action<PlayerStates> OnPlayerStateChanged;

}

public enum PlayerStates {
    Hungry,
    Died,
    Casual
}