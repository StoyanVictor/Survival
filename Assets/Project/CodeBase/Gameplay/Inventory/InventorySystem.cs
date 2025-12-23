using UnityEngine;
namespace Project.CodeBase.Gameplay.Inventory {
    public class InventorySystem : MonoBehaviour {
    
        [SerializeField] private InventoryView _view;
        private InventoryController _controller;

        private void Awake() {
            _controller = new InventoryController(_view);
        }

        public void AddItem(InventoryItemData data) => _controller.AddItem(data);
    }
}