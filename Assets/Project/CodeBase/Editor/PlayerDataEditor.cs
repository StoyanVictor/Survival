using Project.CodeBase.Gameplay.Player;
using UnityEditor;
using UnityEngine;
namespace Project.CodeBase.Editor {
    [CustomEditor(typeof(PlayerData))]
    public class PlayerDataEditor : UnityEditor.Editor {
        public override void OnInspectorGUI() {
            base.OnInspectorGUI();
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Add 5 speed")) {
                PlayerData playerSpawner = (PlayerData)target;
                playerSpawner.AddSpeed();
                Debug.LogError("SpawnPlayer");
            }
            if (GUILayout.Button("Add 5 rotation speed")) {
                PlayerData playerSpawner = (PlayerData)target;
                playerSpawner.AddRotationSpeed();
                Debug.LogError("SpawnPlayer");
            }
            GUILayout.EndHorizontal();
        }
    }
}