using NKHook6.API.Bloons;

namespace NKHook6.API.Events._Bloons
{
    public partial class BloonEvents
    {
        public class MoveEvent : EventBaseCancellable, BloonEvent
        {
            private IBloonEntity bloon;

            public MoveEvent(IBloonEntity bloon) : base("BloonMoveEvent")
            {
                this.bloon = bloon;
            }

            public IBloonEntity getBloon()
            {
                return this.bloon;
            }
        }
    }
}
