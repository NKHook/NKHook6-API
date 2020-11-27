using NKHook6.API.Game;

namespace NKHook6.API.Events._Game
{
	public partial class GameEvents
	{
		public class StartMatchEvent : EventBase
		{
			public IGame game;
			public bool isFromSave;

			public StartMatchEvent(IGame game, bool isFromSave) : base("StartMatchEvent")
			{
				this.game = game;
				this.isFromSave = isFromSave;
			}
		}
	}
}
