namespace NKHook6.API.Events._Game
{
	public partial class GameEvents
	{
		public class VictoryEvent : EventBaseCancellable
		{
			public Game game;
			public VictoryEvent(Game game) : base("VictoryEvent")
			{
				this.game = game;
			}
		}
	}
}
