using UnityEngine;
namespace Project.CodeBase.Gameplay.Player {
    [CreateAssetMenu(fileName = "PlayerData" ,menuName ="Player/Create player data")]
    public class PlayerData : ScriptableObject {
        
        [SerializeField,Range(1,15)] private float _speed = 5f;
        [SerializeField,Range(1,20)] private float _rotationSpeed = 10f;
        [SerializeField,Range(0,100)] private float _maxHealth = 10f;
        [SerializeField,Range(0,100)] private float _maxSatiety = 10f;
        [SerializeField,Range(0,100)] private float _maxTemperature = 10f;
        
        public float Speed => _speed;
        public float RotationSpeed => _rotationSpeed;
        public float GetMaxHealth => _maxHealth;
        public float GetMaxSatiety => _maxSatiety;
        public float GetMaxTemperature => _maxTemperature;

        public void AddSpeed() => _speed += 5;
        public void AddRotationSpeed() => _rotationSpeed += 5;
        
    }
}
