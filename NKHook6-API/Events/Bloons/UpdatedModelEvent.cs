using Assets.Scripts.Models;
using Assets.Scripts.Simulation.Bloons;

namespace NKHook6.Api.Events._Bloons
{
    public partial class BloonEvents
    {
        public class UpdatedModelEvent
        {
            public class Pre : EventBaseCancellable
            {
                public Bloon instance;
                public Model model;

                public Pre(ref Bloon __instance, ref Model modelToUse) : base("Bloon.UpdatedModelEvent.Pre")
                {
                    this.instance = __instance;
                    this.model = modelToUse;
                }
            }

            public class Post : EventBase
            {
                public Bloon instance;
                public Model model;

                public Post(ref Bloon __instance, ref Model modelToUse) : base("Bloon.UpdatedModelEvent.Post")
                {
                    this.instance = __instance;
                    this.model = modelToUse;
                }
            }
        }
    }
}
