using NKHook6.API.Game;
using NKHook6.API.Towers;
using System.Runtime.InteropServices;

namespace NKHook6.API.Events._Player
{
	public partial class PlayerEvents
	{
        [EventInfo("HealthLostEvent")]
		public class HealthLostEvent : HealthChangedEvent
		{
			public HealthLostEvent(IGameInstance game, double oldCash, double newCash) : base(game, oldCash, newCash) { }
		}
	}
}
