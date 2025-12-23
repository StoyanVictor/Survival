using UnityEngine;
namespace Project.CodeBase.Gameplay.Player {
    [CreateAssetMenu(fileName = "PlayerData" ,menuName ="Player/Create player data")]
    public class PlayerData : ScriptableObject {
        
        [SerializeField,Range(1,15)] private float _speed = 5f;
        [SerializeField,Range(1,20)] private float _rotationSpeed = 10f;

        public float Speed => _speed;
        public float RotationSpeed => _rotationSpeed;

        public void AddSpeed() => _speed += 5;
        public void AddRotationSpeed() => _rotationSpeed += 5;
        
    }
}
