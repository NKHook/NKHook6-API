using NKHook6.API.Towers.Projectiles;

namespace NKHook6.API.Events._Projectile
{
	public partial class ProjectileEvents
	{
		public class DeletedEvent : EventBaseCancellable
		{
			public Projectile projectile;

			public DeletedEvent(Projectile projectile) : base("ProjectileDeletedEvent")
			{
				this.projectile = projectile;
			}
		}
	}
}
