using Assets.Scripts.Simulation.Towers;

namespace NKHook6.Api.Events._Towers
{
    public partial class TowerEvents
    {
        public class AddPoppedCashEvent
        {
            public class Pre : EventBaseCancellable
            {
                public Tower instance;
                public float cash;

                public Pre(ref Tower __instance, ref float cash) : base("Tower.AddPoppedCashEvent.Pre")
                {
                    this.instance = __instance;
                    this.cash = cash;
                }
            }

            public class Post : EventBase
            {
                public Tower instance;
                public float cash;

                public Post(ref Tower __instance, ref float cash) : base("Tower.AddPoppedCashEvent.Post")
                {
                    this.instance = __instance;
                    this.cash = cash;
                }
            }
        }
    }
}
