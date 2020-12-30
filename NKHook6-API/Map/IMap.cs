using NKHook6.API.Map;

namespace NKHook6.API.Game {
    public interface IMap {
        string getMapName();
        Area[] getAreas();
        Path[] getPaths();
        PathSplitter getPathSplitter();
    }
}