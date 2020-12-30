using System.Collections.Generic;
using System.Numerics;

namespace NKHook6.API.Map {
    public struct Polygon {
        public IEnumerable<Vector2> area;

        public Polygon(IEnumerable<Vector2> area) {
            this.area = area;
        }
    }
}