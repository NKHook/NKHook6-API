using NKHook6.API.Towers;
using System.Runtime.InteropServices;

namespace NKHook6.API.Events._Player
{
	public partial class PlayerEvents
	{
		public class HealthGainedEvent : HealthChangedEvent
		{
			public HealthGainedEvent(IGame game, double oldCash, double newCash) : base(game, oldCash, newCash) { }
		}
	}
}
