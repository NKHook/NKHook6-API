using NKHook6.API.Game;
using NKHook6.API.Towers;
using System.Runtime.InteropServices;

namespace NKHook6.API.Events._Player
{
	public partial class PlayerEvents
	{
        [EventHeader("HealthChangedEvent")]
		public class HealthChangedEvent : EventBaseCancellable
		{
			public IGameInstance game;
			public double oldCash;
			public double newCash;

			public HealthChangedEvent(IGameInstance game, double oldCash, double newCash) : base()
			{
				this.game = game;
				this.oldCash = oldCash;
				this.newCash = newCash;
			}
		}
	}
}
