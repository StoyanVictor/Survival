using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
namespace Project.CodeBase.Gameplay.Views {
    public class ViewsManager: MonoBehaviour {
        
        [Header("Die")]
        private DieView _dieView;
        [SerializeField] private TextMeshProUGUI _dieText;
        [SerializeField] private Volume _volume;

        private void Awake() {
            _dieView = new DieView(_volume, _dieText);
        }

        private void OnEnable() {
            _dieView.Sub();
        }

        private void OnDisable() {
            _dieView.UnSub();
        }
    }
}
