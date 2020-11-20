using Assets.Scripts.Simulation.Bloons;

namespace NKHook6.Api.Events._Bloons
{
    public partial class BloonEvents
    {
        public class DeletedEvent : EventBaseCancellable
        {
            public Bloon bloon;

            public DeletedEvent(ref Bloon bloon) : base("BloonDeletedEvent")
            {
                this.bloon = bloon;
            }
        }
    }
}
