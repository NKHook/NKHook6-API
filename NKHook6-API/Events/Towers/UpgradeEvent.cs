using NKHook6.API.Towers;

namespace NKHook6.API.Events._Towers
{
	public partial class TowerEvents
	{
		public class UpgradeEvent : EventBaseCancellable
		{
			public Tower tower;
			public UpgradeEvent(Tower tower) : base("TowerUpgradeEvent")
			{
				this.tower = tower;
			}
		}
	}
}
