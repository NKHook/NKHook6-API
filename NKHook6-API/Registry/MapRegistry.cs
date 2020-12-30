using NKHook6.API.Game;
using NKHook6.API.Map;

namespace NKHook6.API.Registry {
    public class MapRegistry : Registry<IMap> {
        public static MapRegistry instance = new MapRegistry();
        public static MapRegistry operator +(MapRegistry inst, IMap map) => (MapRegistry)inst.register(map.getMapName(), map);
        public static MapRegistry operator -(MapRegistry inst, IMap map) => (MapRegistry)inst.unregister(map.getMapName());
        public static IMap operator ^(MapRegistry inst, string tower) => inst.getItem(tower);

        public void test()
        {
            instance += new TestMap();
            IMap testMap = instance ^ "TestMap";
            instance -= new TestMap();
        }
    }

    public class TestMap : IMap {
        public string getMapName() {
            throw new System.NotImplementedException();
        }

        public Area[] getAreas() {
            throw new System.NotImplementedException();
        }

        public Path[] getPaths() {
            throw new System.NotImplementedException();
        }

        public PathSplitter getPathSplitter() {
            throw new System.NotImplementedException();
        }
    }
}