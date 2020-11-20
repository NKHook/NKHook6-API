using Assets.Scripts.Models;
using Assets.Scripts.Simulation.Objects;
using Assets.Scripts.Simulation.Towers.Projectiles;

namespace NKHook6.Api.Events._Projectile
{
	public partial class ProjectileEvents
	{
		public class CreatedEvent : EventBaseCancellable
		{
			public Projectile instance;
			public Entity entity;
			public Model model;

			public CreatedEvent(Projectile __instance, Entity target, Model modelToUse) : base("ProjectileCreatedEvent")
			{
				this.instance = __instance;
				this.entity = target;
				this.model = modelToUse;
			}
		}
	}
}
