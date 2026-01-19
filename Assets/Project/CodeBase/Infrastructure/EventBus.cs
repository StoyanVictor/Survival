using System;
using System.Collections.Generic;
namespace Project.CodeBase.Infrastructure {
    public static class EventBus {
    
        private static readonly Dictionary<Type, Action<IEvent>> _events = new();
        private static readonly Dictionary<Delegate, Action<IEvent>> _wrappers = new();

        public static void Subscribe<T>(Action<T> action) where T : IEvent {
            if (_wrappers.ContainsKey(action)) return;

            Action<IEvent> wrapper = (e) => action((T)e);
            _wrappers[action] = wrapper;

            Type type = typeof(T);
            if (!_events.ContainsKey(type)) _events[type] = null;
            _events[type] += wrapper;
        }

        public static void Unsubscribe<T>(Action<T> action) where T : IEvent {
            if (_wrappers.TryGetValue(action, out var wrapper)) {
                _events[typeof(T)] -= wrapper;
                _wrappers.Remove(action);
            }
        }

        public static void Raise(IEvent ev) {
            if (_events.TryGetValue(ev.GetType(), out var action)) {
                action?.Invoke(ev);
            }
        }
    }
}