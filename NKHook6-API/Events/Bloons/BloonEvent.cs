using NKHook6.API.Bloons;

namespace NKHook6.API.Events._Bloons
{
    public interface BloonEvent
    {
        IBloonEntity GetBloon();
    }
}