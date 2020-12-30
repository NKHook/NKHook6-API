using System.Collections.Generic;
using System.Numerics;

namespace NKHook6.API.Map {
    public struct Polygon {
        /// <summary>
        /// Enumerable list of Vector2s that define the polygons points, if doesn't end with the starting point, will be auto completed
        /// </summary>
        public IEnumerable<Vector2> area;

        /// <summary>
        /// Polygon for use in Area.cs
        /// </summary>
        /// <param name="area">Enumerable list of Vector2s that define the polygons points, if doesn't end with the starting point, will be auto completed</param>
        public Polygon(IEnumerable<Vector2> area) {
            this.area = area;
        }
    }
}