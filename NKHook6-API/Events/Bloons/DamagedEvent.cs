using NKHook6.API.Bloons;
using NKHook6.API.Towers;

namespace NKHook6.Api.Events._Bloons
{
    public partial class BloonEvents
    {
        public class DamagedEvent : EventBaseCancellable
        {
            public Bloon bloon;
            public float damageTaken { get; set; }
            public string[] damageTypes { get; set; }
            public Projectile projectile { get; set; }
            public bool distrubuteToChildren { get; set; }
            public bool overrideDistributeBlocker { get; set; }
            public bool createEffect { get; set; }
            public Tower tower { get; set; }
            public bool canDestroyProjectile { get; set; }
            public string[] ignoreImmunityForBloonTypes { get; set; }
            public bool ignoreNonTargetables { get; set; }
            public bool blockSpawnChildren { get; set; }

            public DamagedEvent(ref Bloon __instance, ref float totalAmount, ref Il2CppStringArray types, ref Projectile projectile,
            ref bool distributeToChildren, ref bool overrideDistributeBlocker, ref bool createEffect, ref Tower tower,
            ref bool canDestroyProjectile, ref Il2CppStringArray ignoreImmunityForBloonTypes, ref bool ignoreNonTargetable,
            ref bool blockSpawnChildren) : base("BloonDamagedEvent")
            {
                this.bloon = __instance;
                this.damageTaken = totalAmount;
                this.damageTypes = types;
                this.projectile = projectile;
                this.distrubuteToChildren = distributeToChildren;
                this.overrideDistributeBlocker = overrideDistributeBlocker;
                this.createEffect = createEffect;
                this.tower = tower;
                this.canDestroyProjectile = canDestroyProjectile;
                this.ignoreImmunityForBloonTypes = ignoreImmunityForBloonTypes;
                this.ignoreNonTargetables = ignoreNonTargetable;
                this.blockSpawnChildren = blockSpawnChildren;
            }
        }
    }
}
