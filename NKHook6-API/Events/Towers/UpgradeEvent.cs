using Assets.Scripts.Simulation.Towers;

namespace NKHook6.Api.Events._Towers
{
	public partial class TowerEvents
	{
		public class UpgradeEvent : EventBaseCancellable
		{
			public Tower tower;
			public UpgradeEvent(ref Tower tower) : base("TowerUpgradeEvent")
			{
				this.tower = tower;
			}
		}
	}
}
