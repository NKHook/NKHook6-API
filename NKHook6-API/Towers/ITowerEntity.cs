using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKHook6.API.Towers
{
    /// <summary>
    /// Tower instance interface
    /// </summary>
    public interface ITowerEntity
    {
        /// <summary>
        /// Get the ITower of the target tower
        /// </summary>
        /// <returns>The ITower</returns>
        ITower GetType();
        /// <summary>
        /// Gets the tower's XYZ position
        /// </summary>
        /// <returns>The tower's XYZ position</returns>
        float[] GetPosition();
        /// <summary>
        /// Returns if a given upgrade was purchased
        /// </summary>
        /// <param name="path">The upgrade path</param>
        /// <param name="tier">The tier of the upgrade</param>
        /// <returns>If a given upgrade was purchased</returns>
        bool IsUpgradePurchased(int path, int tier);
    }
}
