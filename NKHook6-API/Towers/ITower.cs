using NKHook6.API.Towers.Upgrades;

namespace NKHook6.API.Towers
{
    /// <summary>
    /// An interface for creating new towers or getting data from existing towers
    /// </summary>
    public interface ITower
    {
        /// <summary>
        /// The tower's type. This can be a custom type if it is a modded tower
        /// </summary>
        /// <returns>The tower's type</returns>
        string GetType();
        /// <summary>
        /// Returns the upgrade of the tower
        /// </summary>
        /// <param name="path">The upgrade path</param>
        /// <param name="tier">The upgrade tier</param>
        /// <returns></returns>
        IUpgrade GetUpgrade(int path, int tier);
        /// <summary>
        /// Get the base cost of a tower
        /// </summary>
        /// <returns>The base cost of the tower</returns>
        double GetCost();
        /// <summary>
        /// Determines if the tower can be placed in water
        /// </summary>
        /// <returns>True if it can, false if not</returns>
        bool CanPlaceOnWater();
        /// <summary>
        /// Determines if the tower can be placed on land
        /// </summary>
        /// <returns>True if it can, false if not</returns>
        bool CanPlaceOnLand();
        /// <summary>
        /// Determines if the tower can be placed on paths
        /// </summary>
        /// <returns>True if it can, false if not</returns>
        bool CanPlaceOnPath();
        /// <summary>
        /// Determines if the tower can target camo
        /// </summary>
        /// <returns>True if the tower should attack camo</returns>
        bool CanTargetCamo();
        /// <summary>
        /// The radius the tower can attack bloons from
        /// </summary>
        /// <returns>The size of the attack radius</returns>
        double AttackRadius();
        /// <summary>
        /// Makes the tower ignore the radius limit when attacking. The value of ITower#attackRadius will be the size of the circle when the tower is selected.
        /// </summary>
        /// <returns>True if the tower should have infinite range</returns>
        bool IsInfiniteRadius();
        /// <summary>
        /// Determines if the tower should face bloons when attacking
        /// </summary>
        /// <returns>True if the tower should face the bloons its attacking</returns>
        bool RotateToTarget();
    }
}
