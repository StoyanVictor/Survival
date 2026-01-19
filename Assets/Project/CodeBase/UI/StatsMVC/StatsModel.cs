using System;
namespace Project.CodeBase.UI.StatsMVC {
    public class StatsModel {

        private IStat _healthStat;
        private IStat _satietyStat;
        private IStat _temperatureStat;

        public IStat Health => _healthStat;
        public IStat Satiety => _satietyStat;
        public IStat Temperature => _temperatureStat;

        public Action<float> OnHealthChanged;
        public Action<float> OnAppetiteChanges;
        public Action<float> OnTemperatureChanged;
        public Action OnPlayerDied;
        
        public StatsModel(HealthStat health, SatietyStat satiety, TemperatureStat temperature) {
            _healthStat = health;
            _satietyStat = satiety;
            _temperatureStat = temperature;
        }
        
        private void Die() => OnPlayerDied?.Invoke();
        public void IncreaseHealth(float value) {
            _healthStat.Increase(value);
            OnHealthChanged?.Invoke(_healthStat.Stat);
        }
        public void IncreaseTemperature(float value) {
            _temperatureStat.Increase(value);
            OnTemperatureChanged?.Invoke(_temperatureStat.Stat);
        }
        public void IncreaseSatiety(float value) {
            _satietyStat.Increase(value);
            OnAppetiteChanges?.Invoke(_satietyStat.Stat);
        }
        public void DecreaseHealth(float value) {
            _healthStat.Decrease(value);
            OnHealthChanged?.Invoke(_healthStat.Stat);
            if(_healthStat.Stat <= 0)
                Die();
        }
        //TODO ВООБЩЕМ В ЭТОМ СКРИПТЕ НУЖНО ДОБИТЬ ЛОГИКУ ТОГО КОГДА УМИРАЕТ ИГРОК КОГДА ЗАМЕДЛЯЕТСЯ КОГДА ТИКАЕТ УРОН ИТД
        public void DecreaseTemperature(float value,float hpDamageByTic) {
            _temperatureStat.Decrease(value);
            OnTemperatureChanged?.Invoke(_temperatureStat.Stat);
            if(_temperatureStat.Stat <= 0)
                Die();
            if(_temperatureStat.Stat <= 30)
                DecreaseHealth(hpDamageByTic);
        }
        public void DecreaseSatiety(float value) {
            _satietyStat.Decrease(value);
            OnAppetiteChanges?.Invoke(_satietyStat.Stat);
        }
    }
}