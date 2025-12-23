using UnityEngine;
namespace Project.CodeBase.Gameplay.Player {
    public class PaperInteract : MonoBehaviour, IInteractable {
    
        [SerializeField] private ObjectOutliner _outliner;
        [SerializeField] private Rigidbody _rb;
        private GameObject eyesTransform;
        public bool CheckForInteract() => Input.GetKeyDown(KeyCode.E);
        
        private void Update() {
            if (Input.GetKeyDown(KeyCode.G)) {
                transform.parent = null;
                _rb.isKinematic = false;
                _rb.AddForce(eyesTransform.transform.up * 20,ForceMode.Impulse);
            }

        }

        public void Interact() {
             eyesTransform = GameObject.FindGameObjectWithTag("Eyes");
            transform.position = eyesTransform.transform.position;
            transform.rotation = eyesTransform.transform.rotation;
            transform.parent = eyesTransform.transform;
            _rb.isKinematic = true;
        }
        public void ShowHideOutline(bool outlineState) {
            if (outlineState) {
                _outliner.ShowHighlight();
            }
            else {
                _outliner.HideHighlight();
            }
        }
    }
}