using TMPro;
using UnityEngine;
namespace Project.CodeBase.Gameplay.Player {
    public class MessageShower : MonoBehaviour {
        [SerializeField] private TextMeshProUGUI _text;
        public void ShowMessage(string name) {
            _text.text = name;
        }
    }
}