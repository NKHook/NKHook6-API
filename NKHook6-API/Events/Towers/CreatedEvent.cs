using NKHook6.API.Towers;

namespace NKHook6.API.Events._Towers
{
    public partial class TowerEvents
    {
        [EventHeader("TowerCreatedEvent")]
        public class CreatedEvent : EventBase
        {
            public ITowerEntity tower;

            public CreatedEvent(ITowerEntity tower) : base()
            {
                this.tower = tower;
            }
        }
    }
}
