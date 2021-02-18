using NKHook6.API.Game;

namespace NKHook6.API.Events._Game
{
    public partial class GameEvents
    {
        public class RoundEndEvent : EventBaseCancellable
        {
            public IGameInstance game;
            public int round;

            public RoundEndEvent(IGameInstance game, int round) : base("RoundEndEvent")
            {
                this.game = game;
                this.round = round;
            }
        }
    }
}
