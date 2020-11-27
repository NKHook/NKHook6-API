using NKHook6.API.Bloons;

namespace NKHook6.API.Events._Bloons
{
    public partial class BloonEvents
    {
        public class RotateEvent : EventBaseCancellable
        {
            public IBloonEntity bloon;
            public float rotation;

            public RotateEvent(IBloonEntity bloon, float rotation) : base("BloonRotateEvent")
            {
                this.bloon = bloon;
                this.rotation = rotation;
            }
        }
    }
}
