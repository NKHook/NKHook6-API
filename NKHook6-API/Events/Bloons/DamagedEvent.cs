using NKHook6.API.Bloons;
using NKHook6.API.Towers;
using NKHook6.API.Towers.Projectiles;

namespace NKHook6.API.Events._Bloons
{
    public partial class BloonEvents
    {
        [EventHeader("BloonDamagedEvent")]
        public class DamagedEvent : EventBaseCancellable, BloonEvent
        {
            private IBloonEntity bloon;
            private float damageTaken { get; set; }
            private string[] damageTypes { get; set; }
            private IProjectileEntity projectile { get; set; }
            private bool distrubuteToChildren { get; set; }
            private bool overrideDistributeBlocker { get; set; }
            private bool createEffect { get; set; }
            private ITowerEntity tower { get; set; }
            private bool canDestroyProjectile { get; set; }
            private string[] ignoreImmunityForBloonTypes { get; set; }
            private bool ignoreNonTargetables { get; set; }
            private bool blockSpawnChildren { get; set; }

            public DamagedEvent(IBloonEntity bloon, float totalAmount, string[] types, IProjectileEntity projectile,
            bool distributeToChildren, bool overrideDistributeBlocker, bool createEffect, ITowerEntity tower,
            bool canDestroyProjectile, string[] ignoreImmunityForBloonTypes, bool ignoreNonTargetable,
            bool blockSpawnChildren) : base()
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

            public IBloonEntity GetBloon()
            {
                return this.bloon;
            }
        }
    }
}
