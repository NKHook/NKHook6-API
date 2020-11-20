using NKHook6.API.Towers.Projectiles;

namespace NKHook6.API.Events._Projectile
{
	public partial class ProjectileEvents
	{
		public class CreatedEvent : EventBaseCancellable
		{
			public Projectile projectile;

			public CreatedEvent(Projectile projectile) : base("ProjectileCreatedEvent")
			{
				this.projectile = projectile;
			}
		}
	}
}
