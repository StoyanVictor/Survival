using UnityEngine;
namespace Project.CodeBase.UI.StatsMVC {
    public class HealthStat : IStat {

        private float _health;

        public HealthStat(float temperature) {
            Stat = temperature;
        }

        public float Stat {
            get => _health;
            set => _health = Mathf.Clamp(value, 0, 100);
        }

        private void Die() {
        }

        public void Decrease(float value) {
            Stat -= value;
            if(Stat <= 0)
                Die();
        }
        public void Increase(float value) {
            Stat += value;
        }
    }
}