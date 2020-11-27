using NKHook6.API.Bloons;

namespace NKHook6.API.Events._Bloons
{
    public partial class BloonEvents
    {
        public class LeakedEvent : EventBaseCancellable
        {
            public IBloonEntity bloon;

            public LeakedEvent(IBloonEntity bloon) : base("BloonLeakedEvent")
            {
                this.bloon = bloon;
            }
        }
    }
}
