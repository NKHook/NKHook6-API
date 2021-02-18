using NKHook6.API.Game;

namespace NKHook6.API.Events._Game
{
    public partial class GameEvents
    {
        [EventInfo("VictoryEvent")]
        public class VictoryEvent : EventBaseCancellable
        {
            public IGameInstance game;
            public VictoryEvent(IGameInstance game) : base()
            {
                this.game = game;
            }
        }
    }
}
