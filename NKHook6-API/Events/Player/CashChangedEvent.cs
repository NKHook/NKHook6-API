using NKHook6.API.Towers;
using System.Runtime.InteropServices;

namespace NKHook6.API.Events._Player
{
	public partial class PlayerEvents
	{
		public class CashChangedEvent : EventBaseCancellable
		{
			public Game game;
			public double oldCash;
			public double newCash;

			public CashChangedEvent(Game game, double oldCash, double newCash) : base("CashChangedEvent")
			{
				this.game = game;
				this.oldCash = oldCash;
				this.newCash = newCash;
			}
		}
	}
}
