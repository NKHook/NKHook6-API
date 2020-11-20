using NKHook6.API.Towers;

namespace NKHook6.API.Events._Towers
{
	public partial class TowerEvents
	{
		public class SelectedEvent : EventBaseCancellable
		{
			public Tower tower;

			public SelectedEvent(Tower tower) : base("TowerSelectedEvent")
			{
				this.tower = tower;
			}
		}
	}
}
