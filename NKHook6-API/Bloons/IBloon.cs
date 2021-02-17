using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKHook6.API.Bloons
{
    public interface IBloon
    {
        /// <summary>
        /// Gets the full type name as a string
        /// </summary>
        /// <returns>The type name</returns>
        string GetType();
        /// <summary>
        /// Gets the base type name as a string
        /// </summary>
        /// <returns>The base type name</returns>
        string GetBaseType();
        /// <summary>
        /// Gets all applied bloon modifiers
        /// </summary>
        /// <returns>The bloon modifiers</returns>
        Modifier[] GetModifiers();
        /// <summary>
        /// Gets all applied bloon immunities
        /// </summary>
        /// <returns>Applied immunities</returns>
        Immunity[] GetImmunities();
        /// <summary>
        /// Gets the max bloon health
        /// </summary>
        /// <returns>The max health</returns>
        float GetMaxHealth();
        /// <summary>
        /// Gets the leak damage of the bloon
        /// </summary>
        /// <returns>The leak damage</returns>
        float GetLeakDamage();
        /// <summary>
        /// Returns true if the bloon cannot be popped.
        /// </summary>
        /// <returns>The bloon invulnerability</returns>
        bool IsInvulnerable();
        /// <summary>
        /// Gets the bloon's speed
        /// </summary>
        /// <returns>The speed</returns>
        float GetSpeed();
        /// <summary>
        /// Gets how many frames until the bloon next moves
        /// </summary>
        /// <returns>The frames until the bloon can update</returns>
        float GetSpeedFrames();
        /// <summary>
        /// The bloon hitbox radius
        /// </summary>
        /// <returns>The hitbox radius</returns>
        float GetRadius();
        /// <summary>
        /// Gets the threat level of the bloon. Used for targeting.
        /// </summary>
        /// <returns>The threat level</returns>
        float GetDanger();
        /// <summary>
        /// Returns if the bloon can rotate
        /// </summary>
        /// <returns>True if the bloon can rotate</returns>
        bool IsRotateable();
        /// <summary>
        /// Gets the bloon's icon
        /// </summary>
        /// <returns>The bloon's icon path</returns>
        string GetIcon();
        /// <summary>
        /// The path to the bloon's sprite/model
        /// </summary>
        /// <returns>The path to the bloon sprite</returns>
        string GetDisplay();
        /// <summary>
        /// Gets the bloon's tag data
        /// </summary>
        /// <returns>The tag data</returns>
        string[] GetTags();

        enum Modifier { Regen, Camo, Fortified, Moab }
        enum Immunity { Lead, Spikes, Glue, Ice }
    }
}
