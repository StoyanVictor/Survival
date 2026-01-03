using UnityEngine;
namespace Project.CodeBase.UI.StatsMVC {
    public class TemperatureStat: IStat {
        
        private float _temperature;
        
        public TemperatureStat(float temperature) {
            Stat = temperature;
        }
        public float Stat {
            get => _temperature;
            set => _temperature = Mathf.Clamp(value,0,100);
        }
        public void Decrease(float value) {
            Stat -= value;
        }
        public void Increase(float value) {
            Stat += value;
        }
    }
}