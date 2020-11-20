using Assets.Scripts.Simulation;
using Assets.Scripts.Simulation.Towers;
using System.Runtime.InteropServices;

namespace NKHook6.Api.Events._Simulation
{
	public partial class SimulationEvents
	{
		public class CashGainedEvent : EventBaseCancellable
		{
			public Simulation simulation;
			public double cash;
			public Simulation.CashType from;
			public int cashIndex;
			public Simulation.CashSource source;
			public Tower tower;

			public CashGainedEvent(Simulation simulation, double cash,Simulation.CashType from,int cashIndex,Simulation.CashSource source, [Optional]Tower tower) : base("CashGainedEvent")
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
