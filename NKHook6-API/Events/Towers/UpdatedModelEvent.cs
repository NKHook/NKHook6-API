using Assets.Scripts.Models;
using Assets.Scripts.Simulation.Towers;

namespace NKHook6.Api.Events._Towers
{
    public partial class TowerEvents
    {
        public class UpdatedModelEvent
        {
            public class Pre : EventBaseCancellable
            {
                public Tower instance;
                public Model model;

                public Pre(ref Tower __instance, ref Model modelToUse) : base("Tower.UpdatedModelEvent.Pre")
                {
                    this.instance = __instance;
                    this.model = modelToUse;
                }
            }

            public class Post : EventBase
            {
                public Tower instance;
                public Model model;

                public Post(ref Tower __instance, ref Model modelToUse) : base("Tower.UpdatedModelEvent.Post")
                {
                    this.instance = __instance;
                    this.model = modelToUse;
                }
            }
        }
    }
}
