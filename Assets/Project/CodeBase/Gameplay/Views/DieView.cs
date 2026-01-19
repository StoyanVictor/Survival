using Project.CodeBase.Gameplay.Events;
using Project.CodeBase.Infrastructure;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Project.CodeBase.Gameplay.Views {
    public class DieView {
        
        private TextMeshProUGUI _textMeshProUGUI;
        private Volume _volume;

        public DieView(Volume volume, TextMeshProUGUI textMeshProUGUI) {
            
            _volume = volume;
            _textMeshProUGUI = textMeshProUGUI;
        }
        public void Sub() => EventBus.Subscribe<PlayerDiedEvent>(ShowDieView);
        public void UnSub() => EventBus.Unsubscribe<PlayerDiedEvent>(ShowDieView);

        private void ShowDieView(PlayerDiedEvent playerDiedEvent) {
            if (_volume.profile.TryGet(out Vignette vignette)) {
                vignette.color.value = Color.red;
            }
            _textMeshProUGUI.text = playerDiedEvent.GetDeathTime.ToString();
        }
    }
}