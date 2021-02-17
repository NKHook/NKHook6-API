using NKHook6.API.Towers;
using NKHook6.API.Towers.Upgrades;

namespace NKHook6.API.Registry
{
    public class TowerRegistry : Registry<ITower>
    {
        public static TowerRegistry instance = new TowerRegistry();
        public static TowerRegistry operator +(TowerRegistry inst, ITower tower) => (TowerRegistry)inst.Register(tower.GetType(), tower);
        public static TowerRegistry operator -(TowerRegistry inst, ITower tower) => (TowerRegistry)inst.Unregister(tower.GetType());
        public static ITower operator ^(TowerRegistry inst, string tower) => inst.GetItem(tower);
    }
}