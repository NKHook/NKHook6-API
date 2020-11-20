using Assets.Scripts.Simulation;
using Assets.Scripts.Simulation.Towers;
using System.Runtime.InteropServices;

namespace NKHook6.Api.Events._Simulation
{
	public partial class SimulationEvents
	{
		public class CashChangedEvent : EventBaseCancellable
		{
			public Simulation simulation;
			public double cash;
			public Simulation.CashType from;
			public int cashIndex;
			public Simulation.CashSource source;
			public Tower tower;

			public CashChangedEvent(Simulation simulation, double cash, Simulation.CashType from, int cashIndex, Simulation.CashSource source, [Optional] Tower tower) : base("CashChangedEvent")
			{
				this.simulation = simulation;
				this.cash = cash;
				this.from = from;
				this.cashIndex = cashIndex;
				this.source = source;
				this.tower = tower;
			}
		}
	}
}
