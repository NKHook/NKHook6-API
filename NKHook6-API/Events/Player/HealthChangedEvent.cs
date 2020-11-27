using NKHook6.API.Game;
using NKHook6.API.Towers;
using System.Runtime.InteropServices;

namespace NKHook6.API.Events._Player
{
	public partial class PlayerEvents
	{
		public class HealthChangedEvent : EventBaseCancellable
		{
			public IGame game;
			public double oldCash;
			public double newCash;

			public HealthChangedEvent(IGame game, double oldCash, double newCash) : base("HealthChangedEvent")
			{
				this.game = game;
				this.oldCash = oldCash;
				this.newCash = newCash;
			}
		}
	}
}
