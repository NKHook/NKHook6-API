namespace NKHook6.API.Events._Game
{
	public partial class InGameEvents
	{
		public class StartMatchEvent : EventBase
		{
			public Game game;
			public bool isFromSave;

			public StartMatchEvent(Game game, bool isFromSave) : base("StartMatchEvent")
			{
				this.game = game;
				this.isFromSave = isFromSave;
			}
		}
	}
}
