using Assets.Scripts.Simulation;
namespace NKHook6.Api.Events._Simulation
{
	public partial class SimulationEvents
	{
		public class DefeatedEvent : EventBaseCancellable
		{
			public Simulation simulation;
			public DefeatedEvent(ref Simulation simulation) : base("DefeatedEvent")
			{
				this.simulation = simulation;
			}
		}
	}
}
