using System.Collections.Generic;
using NKHook6.API.Map;

namespace NKHook6.API.Game {
    public interface IMap {
        /// <summary>
        /// Gets the name of the Map.
        /// </summary>
        /// <returns>string containing Map Name</returns>
        string getMapName();
        /// <summary>
        /// Gets all Areas in the Map.
        /// </summary>
        /// <returns>IEnumerable&lt;Area&gt; containing All Areas</returns>
        IEnumerable<Area> getAreas();
        /// <summary>
        /// Gets all Paths in the Map.
        /// </summary>
        /// <returns>IEnumerable&lt;Path&gt; containing All Paths</returns>
        IEnumerable<Path> getPaths();
        /// <summary>
        /// Gets the PathSplitter in the Map.
        /// </summary>
        /// <returns>PathSplitter with all information with how the Map will use the Paths</returns>
        PathSplitter getPathSplitter();
    }
}