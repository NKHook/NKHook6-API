using NKHook6.API.Towers;

namespace NKHook6.API.Events._Towers
{
    public partial class TowerEvents
    {
        public class CreatedEvent : EventBase
        {
            public ITowerEntity tower;

            public CreatedEvent(ITowerEntity tower) : base("TowerCreatedEvent")
            {
                this.tower = tower;
            }
        }
    }
}
