using NKHook6.API.Towers;

namespace NKHook6.API.Events._Towers
{
    public partial class TowerEvents
    {
        [EventInfo("TowerCreatedEvent")]
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
