using NKHook6.API.Towers;
using System.Runtime.InteropServices;

namespace NKHook6.API.Events._Player
{
	public partial class PlayerEvents
	{
		public class CashLostEvent : CashChangedEvent
		{
			public CashLostEvent(Game game, double oldCash, double newCash, [Optional] Tower tower) : base(game, oldCash, newCash, tower) { }
		}
	}
}
