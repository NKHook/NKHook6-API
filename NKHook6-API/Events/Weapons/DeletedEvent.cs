using Assets.Scripts.Simulation.Towers.Weapons;

namespace NKHook6.Api.Events._Weapons
{
	public partial class WeaponEvents
	{
		public class DeletedEvent : EventBaseCancellable
		{
			public Weapon weapon;

			public DeletedEvent(ref Weapon weapon) : base("WeaponDeletedEvent")
			{
				this.weapon = weapon;
			}
		}
	}
}
