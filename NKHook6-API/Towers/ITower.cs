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
        string getType();
        /// <summary>
        /// Returns the upgrade of the tower
        /// </summary>
        /// <param name="path">The upgrade path</param>
        /// <param name="tier">The upgrade tier</param>
        /// <returns></returns>
        IUpgrade getUpgrade(int path, int tier);
        /// <summary>
        /// Get the base cost of a tower
        /// </summary>
        /// <returns>The base cost of the tower</returns>
        double getCost();
        /// <summary>
        /// Determines if the tower can be placed in water
        /// </summary>
        /// <returns>True if it can, false if not</returns>
        bool canPlaceOnWater();
        /// <summary>
        /// Determines if the tower can be placed on land
        /// </summary>
        /// <returns>True if it can, false if not</returns>
        bool canPlaceOnLand();
        /// <summary>
        /// Determines if the tower can be placed on paths
        /// </summary>
        /// <returns>True if it can, false if not</returns>
        bool canPlaceOnPath();
        /// <summary>
        /// Determines if the tower can target camo
        /// </summary>
        /// <returns>True if the tower should attack camo</returns>
        bool canTargetCamo();
        /// <summary>
        /// The radius the tower can attack bloons from
        /// </summary>
        /// <returns>The size of the attack radius</returns>
        double attackRadius();
        /// <summary>
        /// Makes the tower ignore the radius limit when attacking. The value of ITower#attackRadius will be the size of the circle when the tower is selected.
        /// </summary>
        /// <returns>True if the tower should have infinite range</returns>
        bool isInfiniteRadius();
        /// <summary>
        /// Determines if the tower should face bloons when attacking
        /// </summary>
        /// <returns>True if the tower should face the bloons its attacking</returns>
        bool rotateToTarget();
    }
}
