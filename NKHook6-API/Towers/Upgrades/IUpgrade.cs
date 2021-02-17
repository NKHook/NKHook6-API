using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKHook6.API.Towers.Upgrades
{
    /// <summary>
    /// An interface for working with Upgrades
    /// </summary>
    public interface IUpgrade
    {
        /// <summary>
        /// Get the cost of the upgrade
        /// </summary>
        /// <returns>The cost of the upgrade</returns>
        double GetCost();
        /// <summary>
        /// Get the name of the upgrade (Non localized)
        /// </summary>
        /// <returns>The name of the upgrade</returns>
        string GetName();
        /// <summary>
        /// Get the description of the upgrade
        /// </summary>
        /// <returns>The upgrade description</returns>
        string GetDescription();
    }
}
