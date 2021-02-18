using NKHook6.API.Towers;

namespace NKHook6.API.Events._Towers
{
	public partial class TowerEvents
	{
        [EventInfo("TowerDeselectedEvent")]
		public class DeselectedEvent : EventBaseCancellable
		{
			public ITowerEntity tower;

			public DeselectedEvent(ITowerEntity tower) : base()
			{
				this.tower = tower;
			}
		}
	}
}
