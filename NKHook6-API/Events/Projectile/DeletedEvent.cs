using Assets.Scripts.Simulation.Towers.Projectiles;

namespace NKHook6.Api.Events._Projectile
{
	public partial class ProjectileEvents
	{
		public class DeletedEvent : EventBaseCancellable
		{
			public Projectile instance;

			public DeletedEvent(Projectile __instance) : base("ProjectileDeletedEvent")
			{
				this.instance = __instance;
			}
		}
	}
}
