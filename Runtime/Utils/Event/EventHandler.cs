using System;
using System.Collections.Generic;

namespace SmallProdGame.Utils {
    public abstract class EventHandler {
        private readonly Dictionary<string, Func<object, object>> _events;

        public EventHandler () {
            _events = new Dictionary<string, Func<object, object>> ();
            InitEvents ();
        }

        protected abstract void InitEvents ();

        protected void On (string name, Func<object, object> func) {
            if (_events.ContainsKey (name)) {
                _events[name] = func;
            } else {
                _events.Add (name, func);
            }
        }

        public object Emit (string name, object data) {
            if (_events.ContainsKey (name)) return _events[name] (data);
            return null;
        }
    }
}