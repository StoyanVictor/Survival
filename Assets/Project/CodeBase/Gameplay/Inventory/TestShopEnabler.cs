using UnityEngine;
namespace Project.CodeBase.Gameplay.Inventory {
    public class TestShopEnabler : MonoBehaviour {
        
        [SerializeField] private GameObject _inventory;
        private bool isOpen;

        private void Update() {
            if (Input.GetKeyDown(KeyCode.I)) {
                ShowInventory();
            }
        }
        private void ShowInventory() {
            if (isOpen) {
                _inventory.SetActive(false);
                isOpen = false;
            }
            else {
                _inventory.SetActive(true);
                isOpen = true;  
            }
        }
    }
}