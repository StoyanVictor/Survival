using System;
using System.Collections.Generic;
namespace Project.CodeBase.Gameplay.Inventory {
    public class InventoryModel {
        
        private Dictionary<InventoryItemData,int> _inventory = new Dictionary<InventoryItemData, int>();
        
        public event Action<Dictionary<InventoryItemData,int>> OnItemAdded;
        
        public void AddItem(InventoryItemData data) {
            if (!_inventory.ContainsKey(data)) {
                _inventory.Add(data,1);
                OnItemAdded?.Invoke(_inventory);
                return;
            }
            _inventory[data] +=1;
            OnItemAdded?.Invoke(_inventory);
        }
    }
}