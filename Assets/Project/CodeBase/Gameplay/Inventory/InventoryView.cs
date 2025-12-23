using System.Collections.Generic;
using UnityEngine;
namespace Project.CodeBase.Gameplay.Inventory {
    public class InventoryView : MonoBehaviour {
        
        [SerializeField] private int _inventorySize;
        [SerializeField] private Transform _parent;
        [SerializeField] private InventoryItemView _itemPrefab;

        private List<InventoryItemView> _inventoryItemViews = new List<InventoryItemView>();
        
        private void Awake() {
            CreateInventoryView();
        }

        public void RedrawInventoryView(Dictionary<InventoryItemData, int> inventoryModel) {
            int i = 0;
            foreach (var inventory in inventoryModel) {
                _inventoryItemViews[i].SetupItemView(inventory.Key.Icon,inventory.Value.ToString());
                i++;
            }
        }

        private void CreateInventoryView() {
            for (int i = 0; i <= _inventorySize; i++) {
                InventoryItemView itemView =Instantiate(_itemPrefab, _parent);
                _inventoryItemViews.Add(itemView);
            }
        }
    }
}