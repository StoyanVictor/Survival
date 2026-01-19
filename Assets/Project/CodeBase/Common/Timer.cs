using Cysharp.Threading.Tasks;

namespace Project.CodeBase.Common {
    public class Timer {
        
        private float _time;
        public float GetCurrentGameTime => StopTimer();
        private bool _stopWatchState;

        public Timer() {
            StartTimer();
        }

        public async void StartTimer() {
            
            _stopWatchState = true;
            
            while (_stopWatchState) {
                await UniTask.WaitForSeconds(1);
                _time++;
            }
        }
        
        private float StopTimer() {
            _stopWatchState = false;
            return _time;
        }
    }
}