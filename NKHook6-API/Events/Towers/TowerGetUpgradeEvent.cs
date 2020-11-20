using Assets.Scripts.Models.Towers.Upgrades;
using Assets.Scripts.Simulation.Towers;

namespace NKHook6.Api.Events.Towers
{
    public class TowerGetUpgradeEvent
    {
        public class Prefix : EventBase
        {
            public Tower tower;
            public int path;
            public bool replaceMethod { get; set; }

            public Prefix(ref Tower __instance, ref int path) : base("TowerGetUpgradeEvent.Pre")
            {
                this.tower = __instance;
                this.path = path;
            }
        }

        public class Postfix : EventBase
        {
            public Tower tower;
            public int path;
            public UpgradeModel result;
            public Postfix(ref Tower __instance, ref int path, ref UpgradeModel __result) : base("TowerGetUpgradeEvent.Post")
            {
                this.tower = __instance;
                this.path = path;
                this.result = __result;
            }
        }
    }
}
