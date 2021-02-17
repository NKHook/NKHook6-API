using System.Collections.Generic;
using NKHook6.API.Game;
using NKHook6.API.Map;

namespace NKHook6.API.Registry {
    public class MapRegistry : Registry<IMap> {
        public static MapRegistry instance = new MapRegistry();
        public static MapRegistry operator +(MapRegistry inst, IMap map) => (MapRegistry)inst.register(map.getMapName(), map);
        public static MapRegistry operator -(MapRegistry inst, IMap map) => (MapRegistry)inst.unregister(map.getMapName());
        public static IMap operator ^(MapRegistry inst, string tower) => inst.getItem(tower);

        public void Test()
        {
            instance += new TestMap();
            IMap testMap = instance ^ "TestMap";
            instance -= new TestMap();
        }
    }

    public class TestMap : IMap {
        public string GetMapName() {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Area> GetAreas() {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Path> GetPaths() {
            throw new System.NotImplementedException();
        }

        public PathSplitter GetPathSplitter() {
            throw new System.NotImplementedException();
        }
    }
}