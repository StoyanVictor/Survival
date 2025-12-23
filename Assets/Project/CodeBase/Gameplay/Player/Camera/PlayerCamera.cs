using Cinemachine;
using UnityEngine;
namespace Project.CodeBase.Gameplay.Player.Camera {
    
    public class PlayerCamera  : MonoBehaviour {
        
        [SerializeField] private CinemachineFreeLook _cinemachineFreeLook;
        [SerializeField,Range(0,20)] private float _rotationSpeed;
        private float _horizontalMouseInput;

        private void Awake() {
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void Update() {
            _horizontalMouseInput = _cinemachineFreeLook.m_XAxis.m_InputAxisValue;
            var a = (_horizontalMouseInput * _rotationSpeed) + _cinemachineFreeLook.transform.eulerAngles.y; 
            if (_horizontalMouseInput >= 1 || _horizontalMouseInput <= 1) {
                var _targetRotation = Quaternion.Euler(0,a, 0);
                _cinemachineFreeLook.gameObject.transform.rotation = Quaternion.Slerp(_cinemachineFreeLook.gameObject.transform.rotation, 
                    _targetRotation ,_rotationSpeed* Time.deltaTime);
                    // Я пиздатый тип
            }
        }
    }
}