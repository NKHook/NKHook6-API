using NKHook6.API.Registry;

namespace NKHook6.API.Map {
    public struct Path {
        public string id;
        public Point[] points;
    }

    public struct PathSplitter {
        public string[] pathNames;

        public PathSplitter(params string[] paths) => pathNames = paths;
    }
}