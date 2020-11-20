using NKHook6.API.Towers;

namespace NKHook6.API.Events._Towers
{
    public partial class TowerEvents
    {
        public class CreatedEvent : EventBase
        {
            public Tower tower;

            public CreatedEvent(Tower tower) : base("TowerCreatedEvent")
            {
                this.tower = tower;
            }
        }
    }
}
