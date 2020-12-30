using System;
using NKHook6.API.Registry;

namespace NKHook6.API.Map {
    public struct Path {
        /// <summary>
        /// Identification for the Path. Used in initialization of the map and Path splitter.
        /// </summary>
        public string id;

        /// <summary>
        /// Array of points that make up this Path.
        /// </summary>
        public Point[] points;

        public Path(string id, params Point[] points) {
            this.id = id;
            this.points = points;
        }
    }

    public struct PathSplitter {
        /// <summary>
        /// Names for the paths to split
        /// </summary>
        public string[] pathNames;

        /// <summary>
        /// Initialises a new PathSplitter with the paths you want.
        /// </summary>
        /// <param name="paths">The Paths ids</param>
        public PathSplitter(params string[] paths) => pathNames = paths;
    }
}