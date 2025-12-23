using TMPro;
using UnityEngine;
using UnityEngine.UI;
namespace Project.CodeBase.Gameplay.Inventory {
    public class InventoryItemView : MonoBehaviour {
        
        [SerializeField] private Image _icon;
        [SerializeField] private TextMeshProUGUI _text;

        public void SetupItemView(Sprite sprite, string count) {
            _icon.sprite = sprite;
            _text.text = count;
        }
    }
}
