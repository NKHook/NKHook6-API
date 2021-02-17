using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKHook6.API.Game
{
    public interface IPlayer
    {
        /// <summary>
        /// Get the player's cash
        /// </summary>
        /// <returns>The player's cash</returns>
        double GetCash();
        /// <summary>
        /// Set the player's cash
        /// </summary>
        /// <param name="value">The value to set the cash</param>
        void SetCash(double value);
    }
}
