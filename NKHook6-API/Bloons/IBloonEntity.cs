using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKHook6.API.Bloons
{
    public interface IBloonEntity
    {
        /// <summary>
        /// Gets the IBloon type of the Bloon
        /// </summary>
        /// <returns>The IBloon</returns>
        IBloon getType();
        /// <summary>
        /// Gets the bloon's path progress
        /// </summary>
        /// <returns></returns>
        float getProgress();
        /// <summary>
        /// Get the 3d position of the bloon in XYZ format
        /// </summary>
        /// <returns>The position of the bloon</returns>
        float[] getPosition();
        /// <summary>
        /// Gets the bloon's rotation
        /// </summary>
        /// <returns></returns>
        float getRotation();
    }
}
