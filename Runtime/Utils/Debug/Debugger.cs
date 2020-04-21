using UnityEngine;

namespace SmallProdGame.Utils {
    public abstract class Debugger {

        public bool debug;

        protected void Log (string txt) {
            if (debug) {
                Debug.Log (txt);
            }
        }

        protected void LogError (object any) {
            if (debug) {
                Debug.LogError (any);
            }
        }
    }
}