using UnityEngine;
namespace Project.CodeBase.Infrastructure.Services {
    public class InputService {
        
        public Vector2 GetInputVector() => 
            new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
}