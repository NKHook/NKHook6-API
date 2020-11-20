using NKHook6.API.Towers;
using System.Runtime.InteropServices;

namespace NKHook6.API.Events._Player
{
	public partial class PlayerEvents
	{
		public class HealthGainedEvent : HealthChangedEvent
		{
			public HealthGainedEvent(Game game, double oldCash, double newCash, [Optional] Tower tower) : base(game, oldCash, newCash, tower) { }
		}
	}
}
