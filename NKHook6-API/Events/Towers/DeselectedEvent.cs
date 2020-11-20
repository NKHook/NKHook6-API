using Assets.Scripts.Simulation.Towers;

namespace NKHook6.Api.Events._Towers
{
	public partial class TowerEvents
	{
		public class DeselectedEvent : EventBaseCancellable
		{
			public Tower tower;

			public DeselectedEvent(ref Tower tower) : base("TowerDeselectedEvent")
			{
				this.tower = tower;
			}
		}
	}
}
