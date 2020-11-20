using Assets.Scripts.Models;
using Assets.Scripts.Simulation.Objects;
using Assets.Scripts.Simulation.Towers.Weapons;

namespace NKHook6.Api.Events._Weapons
{
	public partial class WeaponEvents
	{
		public class CreatedEvent : EventBaseCancellable
		{
			public Weapon instance;
			public Entity entity;
			public Model model;

			public CreatedEvent(ref Weapon __instance, ref Entity target, ref Model modelToUse) : base("WeaponCreatedEvent")
			{
				this.instance = __instance;
				this.entity = target;
				this.model = modelToUse;
			}
		}
	}
}
