using Cinemachine;
using UnityEngine;
namespace Project.CodeBase.Common {
    public class FindPlayerForCineMachine : MonoBehaviour {
        private CinemachineFreeLook _cinemachineFreeLook;

        private void Start() {
            _cinemachineFreeLook = GetComponent<CinemachineFreeLook>();
            var player = GameObject.FindGameObjectWithTag("Player");
            _cinemachineFreeLook.Follow = player.transform;
        }
    }
}