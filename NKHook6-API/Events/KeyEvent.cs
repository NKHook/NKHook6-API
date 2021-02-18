namespace NKHook6.API.Events
{
    [EventHeader("KeyEvent")]
    public class KeyEvent : EventBase
    {
        public char key;
        public KeyEvent(char key) : base()
        {
            this.key = key;
        }
    }
    [EventHeader("KeyPressEvent")]
    public class KeyPressEvent : KeyEvent
    {
        public KeyPressEvent(char key) : base(key) { }
    }
    [EventHeader("KeyHeldEvent")]
    public class KeyHeldEvent : KeyEvent
    {
        public KeyHeldEvent(char key) : base(key) { }
    }
    [EventHeader("KeyReleaseEvent")]
    public class KeyReleaseEvent : KeyEvent
    {
        public KeyReleaseEvent(char key) : base(key) { }
    }
}
