using NKHook6.API.Towers;

namespace NKHook6.API.Events._Towers
{
	public partial class TowerEvents
	{
        [EventHeader("TowerSelectedEvent")]
		public class SelectedEvent : EventBaseCancellable
		{
			public ITowerEntity tower;

			public SelectedEvent(ITowerEntity tower) : base()
			{
				this.tower = tower;
			}
		}
	}
}
