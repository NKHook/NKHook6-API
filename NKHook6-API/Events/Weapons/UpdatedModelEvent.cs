using Assets.Scripts.Models;
using Assets.Scripts.Simulation.Towers.Weapons;

namespace NKHook6.Api.Events._Weapons
{
	public partial class WeaponEvents
	{
		public class UpdatedModelEvent
		{
			public class Pre : EventBaseCancellable
			{
				public Weapon instance;
				public Model model;

				public Pre(ref Weapon __instance, ref Model modelToUse) : base("Weapon.UpdatedModelEvent.Pre")
				{
					this.instance = __instance;
					this.model = modelToUse;
				}
			}

			public class Post : EventBase
			{
				public Weapon instance;
				public Model model;

				public Post(ref Weapon __instance, ref Model modelToUse) : base("Weapon.UpdatedModelEvent.Post")
				{
					this.instance = __instance;
					this.model = modelToUse;
				}
			}
		}
	}
}
