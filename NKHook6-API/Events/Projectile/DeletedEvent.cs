using NKHook6.API.Towers.Projectiles;

namespace NKHook6.API.Events._Projectile
{
	public partial class ProjectileEvents
	{
		public class DeletedEvent : EventBaseCancellable
		{
			public IProjectileEntity projectile;

			public DeletedEvent(IProjectileEntity projectile) : base("ProjectileDeletedEvent")
			{
				this.projectile = projectile;
			}
		}
	}
}
