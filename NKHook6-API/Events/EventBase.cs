namespace NKHook6.API.Events
{
    [EventHeader("EventBase")]
    public abstract class EventBase
    {
        public string eventName;
        public EventBase()
        {
        }
    }
}
