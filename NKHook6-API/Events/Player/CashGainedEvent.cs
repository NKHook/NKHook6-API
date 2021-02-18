using NKHook6.API.Game;
using NKHook6.API.Towers;
using System.Runtime.InteropServices;

namespace NKHook6.API.Events._Player
{
	public partial class PlayerEvents
	{
        [EventHeader("CashGainedEvent")]
		public class CashGainedEvent : CashChangedEvent
		{
			public CashGainedEvent(IGameInstance game, double oldCash, double newCash) : base(game, oldCash, newCash) { }
		}
	}
}
