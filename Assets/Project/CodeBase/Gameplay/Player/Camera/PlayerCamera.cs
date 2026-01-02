using Cinemachine;
using UnityEngine;
namespace Project.CodeBase.Gameplay.Player.Camera {
    
    public class PlayerCamera  : MonoBehaviour {
        
        [SerializeField] private CinemachineFreeLook _cinemachineFreeLook;
        [SerializeField,Range(0,20)] private float _rotationSpeed;
        
        [SerializeField] private bool _horizontalInvert;
        [SerializeField] private bool _verticalInvert;
        
        private float _horizontalMouseInput;
        private float _verticalMouseInput;

        private void Awake() {
            Cursor.lockState = CursorLockMode.Locked;
        }
        private float GetRotationValue(bool invertCheck,float inputType, float cameraAxis) {
            if(!invertCheck)
                return inputType * _rotationSpeed + cameraAxis;
            return -inputType * _rotationSpeed + cameraAxis;
        }
        private void Update() {
            _horizontalMouseInput = _cinemachineFreeLook.m_XAxis.m_InputAxisValue;
            _verticalMouseInput = _cinemachineFreeLook.m_YAxis.m_InputAxisValue;
            var yRotationValue = GetRotationValue(_horizontalInvert,_horizontalMouseInput,_cinemachineFreeLook.transform.eulerAngles.y); 
            var xRotationValue =GetRotationValue(_verticalInvert,_verticalMouseInput,_cinemachineFreeLook.transform.eulerAngles.x);
            if (_horizontalMouseInput >= 1 || _horizontalMouseInput <= 1) {
                var _targetRotation = Quaternion.Euler(xRotationValue,yRotationValue,0);
                _cinemachineFreeLook.gameObject.transform.rotation = Quaternion.Slerp(_cinemachineFreeLook.gameObject.transform.rotation, 
                    _targetRotation ,_rotationSpeed* Time.deltaTime);
                    // Я пиздатый тип
            }
        }
    }
}