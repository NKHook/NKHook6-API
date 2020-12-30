namespace NKHook6.API.Map {
    public struct Area {
        public string id;
        public Polygon polygon;
        public int height;
        public AreaType areaType;

        public Area(string id, Polygon polygon, int height, AreaType areaType) {
            this.id = id;
            this.polygon = polygon;
            this.height = height;
            this.areaType = areaType;
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