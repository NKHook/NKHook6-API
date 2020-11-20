namespace NKHook6.API.Events._Game
{
    public partial class GameEvents
    {
        public class RoundStartEvent : EventBaseCancellable
        {
            public Game game;
            public int round;

            public RoundStartEvent(Game game, int round) : base("RoundStartEvent")
            {
                this.game = game;
                this.round = round;
            }
        }
    }
}
