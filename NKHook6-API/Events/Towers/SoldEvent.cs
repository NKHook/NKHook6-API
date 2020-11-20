using NKHook6.API.Towers;

namespace NKHook6.API.Events._Towers
{
    public partial class TowerEvents
    {
        public class SoldEvent : EventBaseCancellable
        {
            public Tower tower;
            public float sellAmount;

            public SoldEvent(Tower tower, float sellAmount) : base("TowerSoldEvent")
            {
                this.tower = tower;
                this.sellAmount = sellAmount;
            }
        }
    }
}
