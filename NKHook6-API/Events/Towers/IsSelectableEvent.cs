using Assets.Scripts.Simulation.Towers;

namespace NKHook6.Api.Events._Towers
{
    public partial class TowerEvents
    {
        public class IsSelectableEvent
        {
            public class Pre : EventBaseCancellable
            {
                public Tower instance;

                public Pre(ref Tower __instance) : base("Tower.IsSelectableEvent.Pre")
                {
                    this.instance = __instance;
                }
            }

            public class Post : EventBase
            {
                public Tower instance;
                public bool result;
                public Post(ref Tower __instance, ref bool __result) : base("Tower.IsSelectableEvent.Post")
                {
                    this.instance = __instance;
                    this.result = __result;
                }
            }
        }
    }
}
