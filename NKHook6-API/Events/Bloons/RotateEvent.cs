using NKHook6.API.Bloons;

namespace NKHook6.API.Events._Bloons
{
    public partial class BloonEvents
    {
        public class RotateEvent : EventBaseCancellable, BloonEvent
        {
            private IBloonEntity bloon;
            private float rotation;

            public RotateEvent(IBloonEntity bloon, float rotation) : base("BloonRotateEvent")
            {
                this.bloon = bloon;
                this.rotation = rotation;
            }

            public IBloonEntity getBloon()
            {
                return this.bloon;
            }
        }
    }
}
