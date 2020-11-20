using Assets.Scripts.Simulation;

namespace NKHook6.Api.Events._Simulation
{
    public partial class SimulationEvents
    {
        public class RoundEndEvent : EventBaseCancellable
        {
            public Simulation simulation;
            public int roundArrayIndex;

            public RoundEndEvent(ref Simulation simulation, ref int round) : base("RoundEndEvent")
            {
                this.simulation = simulation;
                this.roundArrayIndex = round;
            }
        }
    }
}
