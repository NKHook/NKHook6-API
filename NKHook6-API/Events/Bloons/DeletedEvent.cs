using NKHook6.API.Bloons;

namespace NKHook6.API.Events._Bloons
{
    public partial class BloonEvents
    {
        public class DeletedEvent : EventBaseCancellable, BloonEvent
        {
            private IBloonEntity bloon;

            public DeletedEvent(IBloonEntity bloon) : base("BloonDeletedEvent")
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
