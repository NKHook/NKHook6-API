﻿using NKHook6.API.Registry;

namespace NKHook6.API.Game
{
    /// <summary>
    /// The game instance
    /// </summary>
    public interface IGameInstance
    {
        /// <summary>
        /// Get the player
        /// </summary>
        /// <returns>The player</returns>
        IPlayer GetPlayer();
        /// <summary>
        /// Get any player in the game instance
        /// </summary>
        /// <param name="index">The index of the player to get</param>
        /// <returns>A player</returns>
        IPlayer GetPlayer(int index);
        /// <summary>
        /// Get the health
        /// </summary>
        /// <returns>The health</returns>
        double GetHealth();
        /// <summary>
        /// Set the game's health
        /// </summary>
        /// <param name="value">The value to set the health</param>
        void SetHealth(double value);
        /// <summary>
        /// End the game and have all players see the lose screen
        /// </summary>
        void Lose();
        /// <summary>
        /// Gets the map of the game instance
        /// </summary>
        /// <remarks>The map</remarks>
        IMap GetMap();
    }
}
