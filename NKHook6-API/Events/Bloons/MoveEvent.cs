using Assets.Scripts.Simulation.Bloons;

namespace NKHook6.Api.Events._Bloons
{
    public partial class BloonEvents
    {
        public class MoveEvent : EventBaseCancellable
        {
            public Bloon bloon;
            public float newPosition;
            public float oldPosition;

            public MoveEvent(ref Bloon bloon, ref float newPosition, ref float oldPosition) : base("BloonMoveEvent")
            {
                this.bloon = bloon;
                this.newPosition = newPosition;
                this.oldPosition = oldPosition;
            }
        }
    }
}
