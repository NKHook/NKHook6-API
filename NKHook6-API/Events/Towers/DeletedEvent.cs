using NKHook6.API.Towers;

namespace NKHook6.API.Events._Towers
{
    public partial class TowerEvents
    {
        public class DeletedEvent : EventBase
        {
            public ITowerEntity tower;
            public DeletedEvent(ITowerEntity tower) : base("TowerDeletedEvent")
            {
                this.tower = tower;
            }
        }
    }
}
