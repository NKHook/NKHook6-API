using NKHook6.API.Bloons;

namespace NKHook6.Api.Events._Bloons
{
    public partial class BloonEvents
    {
        public class CreatedEvent : EventBase
        {
            public Bloon bloon;

            public CreatedEvent(Bloon bloon) : base("BloonCreatedEvent")
            {
                this.bloon = bloon;
            }
        }
    }
}
