using NKHook6.API.Bloons;

namespace NKHook6.API.Registry
{
    public class BloonRegistry : Registry<IBloon>
    {
        public static BloonRegistry instance = new BloonRegistry();
    }
}
