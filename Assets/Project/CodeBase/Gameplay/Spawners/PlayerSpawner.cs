using Project.CodeBase.Infrastructure;
using Project.CodeBase.Infrastructure.Services;
using UnityEngine;
namespace Project.CodeBase.Gameplay.Spawners {
    public class PlayerSpawner : MonoBehaviour {
        
        //TODO поменять с геймобджекта на PlayerController чтобы можно было только игрока вставить линк
        [SerializeField] private GameObject _playerPrefab;
        [SerializeField] private Transform _spawnPos;

        private void Awake() => SpawnPlayer(Container.Instance.Factory);
        public void SpawnPlayer(Factory factory) => factory.CreateSomething(_playerPrefab, _spawnPos);
    }
}