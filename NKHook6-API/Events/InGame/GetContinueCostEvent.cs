using Assets.Scripts.Unity.UI_New.InGame;
using Assets.Scripts.Utils;

namespace NKHook6.Api.Events._InGame
{
	public partial class InGameEvents
	{
		public class GetContinueCostEvent
		{
			public class Pre : EventBaseCancellable
			{
				public InGame instance;

				public Pre(ref InGame __instance) : base("InGame.GetContinueCostEvent.Pre")
				{
					this.instance = __instance;
				}
			}

			public class Post : EventBase
			{
				public InGame instance;
				public KonFuze konFuze;

				public Post(ref InGame __instance, ref KonFuze __result) : base("InGame.GetContinueCostEvent.Post")
				{
					this.instance = __instance;
					this.konFuze = __result;
				}
			}
		}
	}
}
