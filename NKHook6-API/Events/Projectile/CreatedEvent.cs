using NKHook6.API.Towers.Projectiles;

namespace NKHook6.API.Events._Projectile
{
	public partial class ProjectileEvents
	{
		public class CreatedEvent : EventBaseCancellable
		{
			public IProjectile projectile;

			public CreatedEvent(IProjectile projectile) : base("ProjectileCreatedEvent")
			{
				this.projectile = projectile;
			}
		}
	}
}
