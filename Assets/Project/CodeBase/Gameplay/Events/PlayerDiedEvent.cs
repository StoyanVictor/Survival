using Project.CodeBase.Infrastructure;
namespace Project.CodeBase.Gameplay.Events {
    public struct PlayerDiedEvent : IEvent {
        
        private float _deathTimer;
        
        public float GetDeathTime => _deathTimer;

        public PlayerDiedEvent(float deathTimer) {
            _deathTimer = deathTimer;
        }
    }
}