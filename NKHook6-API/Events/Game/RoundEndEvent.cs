namespace NKHook6.API.Events._Game
{
    public partial class SimulationEvents
    {
        public class RoundEndEvent : EventBaseCancellable
        {
            public Game game;
            public int round;

            public RoundEndEvent(Game game, int round) : base("RoundEndEvent")
            {
                this.game = game;
                this.round = round;
            }
        }
    }
}
