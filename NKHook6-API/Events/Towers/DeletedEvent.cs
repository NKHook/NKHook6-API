using NKHook6.API.Towers;

namespace NKHook6.API.Events._Towers
{
    public partial class TowerEvents
    {
        public class DeletedEvent : EventBase
        {
            public Tower instance;
            public DeletedEvent(ref Tower __instance) : base("TowerDeletedEvent")
            {
                this.instance = __instance;
            }
        }
    }
}
