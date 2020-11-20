using Assets.Scripts.Simulation.Bloons;

namespace NKHook6.Api.Events._Bloons
{
    public partial class BloonEvents
    {
        public class LeakedEvent : EventBaseCancellable
        {
            public Bloon bloon;

            public LeakedEvent(ref Bloon bloon) : base("BloonLeakedEvent")
            {
                this.bloon = bloon;
            }
        }
    }
}
