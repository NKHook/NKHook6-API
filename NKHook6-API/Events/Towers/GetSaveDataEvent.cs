using Assets.Scripts.Models.Profile;
using Assets.Scripts.Simulation.Towers;

namespace NKHook6.Api.Events._Towers
{
    public partial class TowerEvents
    {
        public class GetSaveDataEvent
        {
            public class Pre : EventBaseCancellable
            {
                public Tower instance;

                public Pre(ref Tower __instance) : base("Tower.GetSaveDataEvent.Pre")
                {
                    this.instance = __instance;
                }
            }

            public class Post : EventBase
            {
                public Tower instance;
                public TowerSaveDataModel result;
                public Post(ref Tower __instance, ref TowerSaveDataModel __result) : base("Tower.GetSaveDataEvent.Post")
                {
                    this.instance = __instance;
                    this.result = __result;
                }
            }
        }
    }
}
