namespace NKHook6.API.Events._Game
{
	public partial class GameEvents
	{
		public class VictoryEvent : EventBaseCancellable
		{
			public IGame game;
			public VictoryEvent(IGame game) : base("VictoryEvent")
			{
				this.game = game;
			}
		}
	}
}
