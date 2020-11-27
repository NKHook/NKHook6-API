using NKHook6.API.Game;

namespace NKHook6.API.Events._Game
{
    public partial class SimulationEvents
    {
        public class RoundEndEvent : EventBaseCancellable
        {
            public IGame game;
            public int round;

            public RoundEndEvent(IGame game, int round) : base("RoundEndEvent")
            {
                this.game = game;
                this.round = round;
            }
        }
    }
}
