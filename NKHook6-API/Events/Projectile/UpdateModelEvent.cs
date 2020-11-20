using Assets.Scripts.Models;
using Assets.Scripts.Simulation.Towers.Projectiles;

namespace NKHook6.Api.Events._Projectile
{
	public class UpdatedModelEvent
	{
		public class Pre : EventBaseCancellable
		{
			public Projectile instance;
			public Model model;

			public Pre(ref Projectile __instance, ref Model modelToUse) : base("Projectile.UpdatedModelEvent.Pre")
			{
				this.instance = __instance;
				this.model = modelToUse;
			}
		}

		public class Post : EventBase
		{
			public Projectile instance;
			public Model model;

			public Post(ref Projectile __instance, ref Model modelToUse) : base("Projectile.UpdatedModelEvent.Post")
			{
				this.instance = __instance;
				this.model = modelToUse;
			}
		}
	}

}
