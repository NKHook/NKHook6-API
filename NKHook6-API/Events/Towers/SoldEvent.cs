using NKHook6.API.Towers;

namespace NKHook6.API.Events._Towers
{
    public partial class TowerEvents
    {
        [EventHeader("TowerSoldEvent")]
        public class SoldEvent : EventBaseCancellable
        {
            public ITowerEntity tower;
            public float sellAmount;

            public SoldEvent(ITowerEntity tower, float sellAmount) : base()
            {
                this.tower = tower;
                this.sellAmount = sellAmount;
            }
        }
    }
}
