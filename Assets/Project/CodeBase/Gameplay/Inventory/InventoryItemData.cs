using UnityEngine;
namespace Project.CodeBase.Gameplay.Inventory {
    [CreateAssetMenu(fileName = "Item", menuName = "Inventory/Create item")]
    public class InventoryItemData : ScriptableObject {
        [SerializeField] private string _name;
        [SerializeField] private Sprite _icon;
        public ItemType _itemType;

        public Sprite Icon => _icon;
        public string Name => _name;
        
    }
}

public enum ItemType {
    Wood,
    Stone,
    Meat
}