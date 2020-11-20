namespace NKHook6.API.Events
{
    public abstract class EventBase
    {
        public string eventName;
        public EventBase(string eventName)
        {
            this.eventName = eventName;
        }
    }
}
