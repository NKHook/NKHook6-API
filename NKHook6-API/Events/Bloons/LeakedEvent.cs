using NKHook6.API.Bloons;

namespace NKHook6.API.Events._Bloons
{
    public partial class BloonEvents
    {
        public class LeakedEvent : EventBaseCancellable
        {
            public Bloon bloon;

            public LeakedEvent(Bloon bloon) : base("BloonLeakedEvent")
            {
                this.bloon = bloon;
            }
        }
    }
}
