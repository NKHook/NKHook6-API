using Assets.Scripts.Simulation;

namespace NKHook6.Api.Events._Simulation
{
	public partial class SimulationEvents
	{
		public class CashLostEvent : EventBaseCancellable
		{
			public Simulation simulation;
			public double cash;
			public Simulation.CashType from;
			public int cashIndex;
			public Simulation.CashSource source;

			public CashLostEvent(Simulation simulation, double cash, Simulation.CashType from, int cashIndex, Simulation.CashSource source) : base("CashLostEvent")
			{
				this.simulation = simulation;
				this.cash = cash;
				this.from = from;
				this.cashIndex = cashIndex;
				this.source = source;
			}
		}
	}
}
