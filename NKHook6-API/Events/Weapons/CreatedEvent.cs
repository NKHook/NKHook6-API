﻿using NKHook6.API.Towers.Weapons;

namespace NKHook6.API.Events._Weapons
{
	public partial class WeaponEvents
	{
        [EventHeader("WeaponCreatedEvent")]
		public class CreatedEvent : EventBaseCancellable
		{
			public IWeapon weapon;

			public CreatedEvent(IWeapon weapon) : base()
			{
				this.weapon = weapon;
			}
		}
	}
}
