using NKHook6.API.Bloons;

namespace NKHook6.API.Events._Bloons
{
    public partial class BloonEvents
    {
        public class MoveEvent : EventBaseCancellable
        {
            public IBloonEntity bloon;
            public float newPosition;
            public float oldPosition;

            public MoveEvent(IBloonEntity bloon, float newPosition, float oldPosition) : base("BloonMoveEvent")
            {
                this.bloon = bloon;
                this.newPosition = newPosition;
                this.oldPosition = oldPosition;
            }
        }
    }
}
