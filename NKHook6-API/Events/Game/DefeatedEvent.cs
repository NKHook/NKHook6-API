using NKHook6.API.Game;

namespace NKHook6.API.Events._Game
{
    public partial class GameEvents
    {
        [EventHeader("DefeatedEvent")]
        public class DefeatedEvent : EventBaseCancellable
        {
            public IGameInstance game;
            public DefeatedEvent(IGameInstance game) : base()
            {
                this.game = game;
            }
        }
    }
}
