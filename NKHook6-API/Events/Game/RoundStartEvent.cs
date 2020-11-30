using NKHook6.API.Game;

namespace NKHook6.API.Events._Game
{
    public partial class GameEvents
    {
        public class RoundStartEvent : EventBaseCancellable
        {
            public IGameInstance game;
            public int round;

            public RoundStartEvent(IGameInstance game, int round) : base("RoundStartEvent")
            {
                this.game = game;
                this.round = round;
            }
        }
    }
}
