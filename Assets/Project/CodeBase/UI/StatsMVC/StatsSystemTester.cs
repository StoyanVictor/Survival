using UnityEngine;
namespace Project.CodeBase.UI.StatsMVC {
    
    [ExecuteAlways]
    public class StatsSystemTester: MonoBehaviour {
        [SerializeField] private StatsSystem _statsSystem;

        private void Update() {
            if(Input.GetKeyDown(KeyCode.H))
                _statsSystem.DecreaseSatiety(10);
            if(Input.GetKeyDown(KeyCode.J))
                _statsSystem.IncreaseSatiety(10);
        }
    }
}