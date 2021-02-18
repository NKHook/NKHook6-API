namespace NKHook6.API.Game
{
    /// <summary>
    /// The main game object
    /// </summary>
    public interface IGame
    {
        /// <summary>
        /// Get the in game instance
        /// </summary>
        /// <returns>The game instance</returns>
        IGameInstance GetGameInstance();

        /// <summary>
        /// Gets the bloon registry instance
        /// </summary>
        /// <returns>The bloon registry</returns>
        BloonRegistry GetBloonRegistry();

        /// <summary>
        /// Gets the event registry instance
        /// </summary>
        /// <returns>The event registry</returns>
        EventRegistry GetEventRegistry();

        /// <summary>
        /// Gets the map registry instance
        /// </summary>
        /// <returns>The map registry</returns>
        MapRegistry GetMapRegistry();

        /// <summary>
        /// Gets the tower registry instance
        /// </summary>
        /// <returns>The tower registry</returns>
        TowerRegistry GetTowerRegistry();

        /// <summary>
        /// Gets the amount of monkey money the user has
        /// </summary>
        /// <returns>Amount of monkey money</returns>
        double GetMonkeyMoney();
    }
}