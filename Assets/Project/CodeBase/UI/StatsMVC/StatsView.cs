using TMPro;
using UnityEngine;
using UnityEngine.UI;
namespace Project.CodeBase.UI.StatsMVC {
    public class StatsView: MonoBehaviour {
        
        [Header("Stats percent"),Space(5)]
        [SerializeField] private TextMeshProUGUI _healthPercent;
        [SerializeField] private TextMeshProUGUI _satietyPercent;
        [SerializeField] private TextMeshProUGUI _temperaturePercent;
        
        [Header("Stats Sliders"),Space(5)]
        [SerializeField] private Slider _healthSlider;
        [SerializeField] private Slider _satietySlider;
        [SerializeField] private Slider _temperatureSlider;

        public void Init(float healthMaxValue, float satietyMaxValue, float temperatureMaxValue) {
            _healthSlider.maxValue = healthMaxValue;
            _healthSlider.value = healthMaxValue;
            _satietySlider.maxValue = satietyMaxValue;
            _satietySlider.value = satietyMaxValue;
            _temperatureSlider.maxValue = temperatureMaxValue;
            _temperatureSlider.value = temperatureMaxValue;
        }

        public void ChangeHealthStat(float healthValue) {
            _healthSlider.value = healthValue;
            _healthPercent.text = healthValue + "%";
        }

        public void ChangeSatietyStat(float satietyValue) {
            _satietySlider.value = satietyValue;
            _satietyPercent.text = satietyValue + "%";
        }

        public void ChangeTemperatureStat(float temperatureValue) {
            _temperatureSlider.value = temperatureValue;
            _temperaturePercent.text = temperatureValue + "%";
        }
    }
}