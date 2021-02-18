using NKHook6.API.Towers;

namespace NKHook6.API.Events._Towers
{
    public partial class TowerEvents
    {
        [EventInfo("TowerDeletedEvent")]
        public class DeletedEvent : EventBase
        {
            public ITowerEntity tower;
            public DeletedEvent(ITowerEntity tower) : base()
            {
                this.tower = tower;
            }
        }
    }
}
