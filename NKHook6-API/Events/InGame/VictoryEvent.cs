using Assets.Scripts.Unity.UI_New.InGame;

namespace NKHook6.Api.Events._InGame
{
	public partial class InGameEvents
	{
		public class VictoryEvent : EventBaseCancellable
		{
			public InGame inGame;

			public VictoryEvent(ref InGame inGame) : base("VictoryEvent")
			{
				this.inGame = inGame;
			}
		}
	}
}
