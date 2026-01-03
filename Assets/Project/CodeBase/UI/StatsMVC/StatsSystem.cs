using Project.CodeBase.Gameplay.Player;
using UnityEngine;
namespace Project.CodeBase.UI.StatsMVC {
    public class StatsSystem: MonoBehaviour {
        
        [SerializeField] private StatsView _statsView;
        [SerializeField] private PlayerData _playerData;
        
        private StatsController _statsController;
        
        private void Awake() {
            _statsController = new StatsController(_statsView,_playerData);
        }
        
        public void IncreaseHealth(float value) => _statsController.GetModel.IncreaseHealth(value);
        public void IncreaseSatiety(float value) => _statsController.GetModel.IncreaseSatiety(value);
        
        public void IncreaseTemperature(float value) => _statsController.GetModel.IncreaseTemperature(value);
        
        public void DecreaseHealth(float value) => _statsController.GetModel.DecreaseHealth(value);
        public void DecreaseSatiety(float value) => _statsController.GetModel.DecreaseSatiety(value);
        //TODO ТУТ КОРОЧ МАГИЧЕСКОЕ ЧИСЛО НАДО ИСПРАВИТЬ 
        public void DecreaseTemperature(float value) => _statsController.GetModel.DecreaseTemperature(value,2);
        
    }
}