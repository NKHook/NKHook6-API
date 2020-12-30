namespace NKHook6.API.Map {
    public struct Area {
        /// <summary>
        /// Identification for the area. Used in initialization of the map.
        /// </summary>
        public string id;

        /// <summary>
        /// Polygon that controls the actual object this area will be initializing.
        /// </summary>
        public Polygon polygon;

        /// <summary>
        /// Height offset for the polygon; this is used for blockers.
        /// </summary>
        public int height;

        /// <summary>
        /// Type of area the polygon will be initialized with. Types include: None, Water, Track, Land, & Unplaceable
        /// </summary>
        public AreaType areaType;

        /// <summary>
        /// Determines if this polygon is meant to obscure the monkeys vision.
        /// </summary>
        public bool isBlocker;

        public Area(string id, Polygon polygon, int height, AreaType areaType, bool isBlocker = false) {
            this.id = id;
            this.polygon = polygon;
            this.height = height;
            this.areaType = areaType;
            this.isBlocker = isBlocker;
        }
    }

    public enum AreaType {
        none,
        water,
        track,
        land,
        unplaceable
    }
}