using UnityEngine;
namespace Project.CodeBase.UI.StatsMVC {
    public class SatietyStat: IStat {
        
        private float _hunger;
        
        public SatietyStat(float temperature) {
            Stat = temperature;
        }
        public float Stat {
            get => _hunger;
            set => _hunger = Mathf.Clamp(value,0,100);
        }
        public void Decrease(float value) {
            Stat -= value;
        }
        public void Increase(float value) {
            Stat += value;
        }
    }
}