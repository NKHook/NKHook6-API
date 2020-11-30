using NKHook6.API.Game;

namespace NKHook6.API.Events._Game
{
	public partial class GameEvents
	{
		public class VictoryEvent : EventBaseCancellable
		{
			public IGameInstance game;
			public VictoryEvent(IGameInstance game) : base("VictoryEvent")
			{
				this.game = game;
			}
		}
	}
}
