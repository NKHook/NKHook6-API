using NKHook6.API.Bloons;

namespace NKHook6.API.Events._Bloons
{
    public partial class BloonEvents
    {
        public class DeletedEvent : EventBaseCancellable
        {
            public Bloon bloon;

            public DeletedEvent(Bloon bloon) : base("BloonDeletedEvent")
            {
                this.bloon = bloon;
            }
        }
    }
}
