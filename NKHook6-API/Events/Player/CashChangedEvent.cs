using NKHook6.API.Towers;
using System.Runtime.InteropServices;

namespace NKHook6.API.Events._Simulation
{
	public partial class PlayerEvents
	{
		public class CashChangedEvent : EventBaseCancellable
		{
			public Game game;
			public double oldCash;
			public double newCash;
			public Tower tower;

			public CashChangedEvent(Game game, double oldCash, double newCash, [Optional] Tower tower) : base("CashChangedEvent")
			{
				this.game = game;
				this.oldCash = oldCash;
				this.newCash = newCash;
				this.tower = tower;
			}
		}
	}
}
