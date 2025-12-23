using Project.CodeBase.Gameplay.Spawners;
using Project.CodeBase.Infrastructure.Services;
using UnityEditor;
using UnityEngine;
namespace Project.CodeBase.Editor {
    [CustomEditor(typeof(PlayerSpawner))]
    public class PlayerSpawnerEditor : UnityEditor.Editor {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (GUILayout.Button("CreatePlayer"))
            {
                PlayerSpawner playerSpawner = (PlayerSpawner)target;
                playerSpawner.SpawnPlayer(new Factory());
                Debug.LogError("SpawnPlayer");
            }
        }
    }
}

