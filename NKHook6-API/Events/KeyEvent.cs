namespace NKHook6.API.Events
{
    [EventInfo("KeyEvent")]
    public class KeyEvent : EventBase
    {
        public char key;
        public KeyEvent(char key, string eventName) : base(eventName)
        {
            this.key = key;
        }
    }
    [EventInfo("KeyPressEvent")]
    public class KeyPressEvent : KeyEvent
    {
        public KeyPressEvent(char key) : base(key, "KeyPressEvent") { }
    }
    public class KeyHeldEvent : KeyEvent
    {
        public KeyHeldEvent(char key) : base(key, "KeyHeldEvent") { }
    }
    public class KeyReleaseEvent : KeyEvent
    {
        public KeyReleaseEvent(char key) : base(key, "KeyReleaseEvent") { }
    }
}
