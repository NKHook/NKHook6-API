namespace NKHook6.API.Game.Map
{
    public interface IMap
    {
        IPath getPath();
        IMapObject[] getObjects();
    }
}