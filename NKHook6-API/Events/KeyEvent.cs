using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace NKHook6.Api.Events
{
    public class KeyEvent : EventBase
    {
        public KeyCode key;
        public KeyEvent(KeyCode key, string eventName) : base(eventName)
        {
            this.key = key;
        }
    }
    public class KeyPressEvent : KeyEvent
    {
        public KeyPressEvent(KeyCode key) : base(key, "KeyPressEvent") { }
    }
    public class KeyHeldEvent : KeyEvent
    {
        public KeyHeldEvent(KeyCode key) : base(key, "KeyHeldEvent") { }
    }
    public class KeyReleaseEvent : KeyEvent
    {
        public KeyReleaseEvent(KeyCode key) : base(key, "KeyReleaseEvent") { }
    }
}
