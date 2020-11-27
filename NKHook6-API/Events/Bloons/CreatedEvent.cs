using NKHook6.API.Bloons;

namespace NKHook6.API.Events._Bloons
{
    public partial class BloonEvents
    {
        public class CreatedEvent : EventBase
        {
            public IBloonEntity bloon;

            public CreatedEvent(IBloonEntity bloon) : base("BloonCreatedEvent")
            {
                this.bloon = bloon;
            }
        }
    }
}
