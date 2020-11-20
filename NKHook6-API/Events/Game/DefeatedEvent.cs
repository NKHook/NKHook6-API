namespace NKHook6.API.Events._Game
{
	public partial class GameEvents
	{
		public class DefeatedEvent : EventBaseCancellable
		{
			public Game game;
			public DefeatedEvent(Game game) : base("DefeatedEvent")
			{
				this.game = game;
			}
		}
	}
}
