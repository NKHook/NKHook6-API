using Assets.Scripts.Models;
using Assets.Scripts.Simulation.Objects;
using Assets.Scripts.Simulation.Towers;

namespace NKHook6.Api.Events._Towers
{
    public partial class TowerEvents
    {
        public class CreatedEvent : EventBase
        {
            public Tower tower;
            public Entity entity;
            public Model model;

            public CreatedEvent(ref Tower tower, ref Entity target, ref Model modelToUse) : base("TowerCreatedEvent")
            {
                this.tower = tower;
                this.entity = target;
                this.model = modelToUse;
            }
        }
    }
}
