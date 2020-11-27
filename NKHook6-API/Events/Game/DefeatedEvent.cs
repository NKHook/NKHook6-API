using NKHook6.API.Game;

namespace NKHook6.API.Events._Game
{
	public partial class GameEvents
	{
		public class DefeatedEvent : EventBaseCancellable
		{
			public IGame game;
			public DefeatedEvent(IGame game) : base("DefeatedEvent")
			{
				this.game = game;
			}
		}
	}
}
