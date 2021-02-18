using NKHook6.API.Bloons;

namespace NKHook6.API.Events._Bloons
{
    public partial class BloonEvents
    {
        [EventHeader("BloonMoveEvent")]
        public class MoveEvent : EventBaseCancellable, BloonEvent
        {
            private IBloonEntity bloon;

            public MoveEvent(IBloonEntity bloon) : base()
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
