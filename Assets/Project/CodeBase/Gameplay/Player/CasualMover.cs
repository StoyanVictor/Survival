using Project.CodeBase.Infrastructure;
using UnityEngine;
namespace Project.CodeBase.Gameplay.Player {
    public class CasualMover : IMovable {
    
        private CharacterController _controller;
        private PlayerData _playerConfig;
        public CasualMover(CharacterController controller, PlayerData playerConfig) {
            this._controller = controller;
            _playerConfig = playerConfig;
        }
        public void Move() {
            var cameraYRotationAngle =  UnityEngine.Camera.main.transform.localEulerAngles.y;
            //Тут кватернионы множатся на вектор, чтоб получить финальный вектор направления с учётом Y Camera 
            Vector3 moveVectorWithRotationAngle = Quaternion.Euler(0,cameraYRotationAngle,0) * 
                                                  new Vector3(Container.Instance.InputService.GetInputVector().x,
                                                      0f, Container.Instance.InputService.GetInputVector().y);
            
            if (moveVectorWithRotationAngle.magnitude > 0.1f && Container.Instance.InputService.GetInputVector() != Vector2.zero) {
                _controller.Move(moveVectorWithRotationAngle * _playerConfig.Speed * Time.deltaTime);
                // Поворот к направлению движения
                Quaternion targetRotation = Quaternion.Euler(0,cameraYRotationAngle,0);
                _controller.gameObject.transform.rotation = Quaternion.Slerp(
                    _controller.gameObject.transform.rotation,
                    targetRotation,
                    _playerConfig.RotationSpeed * Time.deltaTime
                );
            }
        }
    }
}