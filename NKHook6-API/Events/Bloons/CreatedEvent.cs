using NKHook6.API.Bloons;

namespace NKHook6.API.Events._Bloons
{
    public partial class BloonEvents
    {
        [EventHeader("BloonCreatedEvent")]
        public class CreatedEvent : EventBase, BloonEvent
        {
            private IBloonEntity bloon;

            public CreatedEvent(IBloonEntity bloon) : base()
            {
                this.bloon = bloon;
            }

            public IBloonEntity GetBloon()
            {
                return this.bloon;
            }
        }
    }
}
