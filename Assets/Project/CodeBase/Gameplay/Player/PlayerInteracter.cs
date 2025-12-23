using Project.CodeBase.Gameplay.Inventory;
using UnityEngine;
namespace Project.CodeBase.Gameplay.Player {
    public class PlayerInteracter : MonoBehaviour {

        [SerializeField] private LayerMask _interactMask;
        [SerializeField,Range(0,50)]private float _maxDistance;
        [SerializeField] private MessageShower _messageShower;
        
        [SerializeField] private InventorySystem _inventorySystem;
        
        private IInteractable interactableObject;
        
        private void Update() {
            RayCast();
            
        }
        private void RayCast() {
            RaycastHit raycastHit;
            Ray ray = new Ray(UnityEngine.Camera.main.transform.position,
                UnityEngine.Camera.main.transform.forward);
            if (Physics.Raycast(ray, out raycastHit,_maxDistance,_interactMask)) {
                raycastHit.transform.TryGetComponent(out IInteractable interactable);
               raycastHit.transform.TryGetComponent(out IItem item);
                    interactableObject = interactable;
                    _messageShower.ShowMessage("Press E to interact");
                    interactableObject.ShowHideOutline(true);
                    if (interactable.CheckForInteract()) {
                        interactable.Interact();
                        item?.TakeItem(_inventorySystem);
                    }

            }
            else {
                interactableObject?.ShowHideOutline(false);
                _messageShower.ShowMessage("");
            }
        }
    }
}