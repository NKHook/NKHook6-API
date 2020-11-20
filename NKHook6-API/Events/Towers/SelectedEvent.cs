using Assets.Scripts.Simulation.Towers;

namespace NKHook6.Api.Events._Towers
{
	public partial class TowerEvents
	{
		public class SelectedEvent : EventBaseCancellable
		{
			public Tower tower;

			public SelectedEvent(ref Tower tower) : base("TowerSelectedEvent")
			{
				this.tower = tower;
			}
		}
	}
}
