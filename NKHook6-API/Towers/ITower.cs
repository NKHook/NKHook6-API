using NKHook6.API.Towers.Upgrades;

namespace NKHook6.API.Towers
{
    public interface ITower
    {
        Upgrade getUpgrade(int path, int tier);
    }
}
