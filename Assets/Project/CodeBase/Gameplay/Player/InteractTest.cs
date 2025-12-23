using Project.CodeBase.Gameplay.Inventory;
using UnityEngine;
namespace Project.CodeBase.Gameplay.Player {
    public class InteractTest : MonoBehaviour,IInteractable,IItem {
        
        [SerializeField] private ObjectOutliner _outliner;
        [SerializeField] private InventoryItemData _itemData;
        
        public bool CheckForInteract() => Input.GetKeyDown(KeyCode.E);
        
        public void Interact() {
            Debug.LogError("Print interact!");
            Destroy(gameObject); 
        }
        //When true показывает оут лайн если фолс прячет
        public void ShowHideOutline(bool outlineState) {
            if (outlineState) {
                _outliner.ShowHighlight();
            }
            else {
                _outliner.HideHighlight();
            }
        }
        public void TakeItem(InventorySystem inventorySystem) {
            inventorySystem.AddItem(_itemData);
        }
    }
}