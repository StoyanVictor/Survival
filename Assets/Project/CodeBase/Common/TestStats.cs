using Project.CodeBase.UI.StatsMVC;
using UnityEngine;
namespace Project.CodeBase.Common {
    public class TestStats : MonoBehaviour {

        [SerializeField] private StatsSystem _statsSystem;

        private void Update() {
            if(Input.GetKeyDown(KeyCode.K))
                _statsSystem.DecreaseHealth(30);
        }
    }
}