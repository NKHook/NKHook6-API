using Assets.Scripts.Simulation;

namespace NKHook6.API.Events._Simulation
{
    public partial class SimulationEvents
    {
        public class RoundStartEvent : EventBaseCancellable
        {
            public Simulation simulation;
            public int roundArrayIndex;

            public RoundStartEvent(ref Simulation simulation, ref int roundArrayIndex) : base("RoundStartEvent")
            {
                this.simulation = simulation;
                this.roundArrayIndex = roundArrayIndex;
            }
        }
    }
}
