using NKHook6.API.Bloons;
using NKHook6.API.Towers;
using NKHook6.API.Towers.Projectiles;

namespace NKHook6.API.Events._Bloons
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

            public DamagedEvent(Bloon bloon, float totalAmount, string[] types, Projectile projectile,
            bool distributeToChildren, bool overrideDistributeBlocker, bool createEffect, Tower tower,
            bool canDestroyProjectile, string[] ignoreImmunityForBloonTypes, bool ignoreNonTargetable,
            bool blockSpawnChildren) : base("BloonDamagedEvent")
            {
                this.bloon = bloon;
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
