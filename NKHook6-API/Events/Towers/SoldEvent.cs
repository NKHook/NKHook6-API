using Assets.Scripts.Simulation.Towers;

namespace NKHook6.Api.Events._Towers
{
    public partial class TowerEvents
    {
        public class SoldEvent : EventBaseCancellable
        {
            public Tower instance;
            public float sellAmount;

            public SoldEvent(ref Tower __instance, ref float sellAmount) : base("TowerSoldEvent")
            {
                this.instance = __instance;
                this.sellAmount = sellAmount;
            }
        }
    }
}
