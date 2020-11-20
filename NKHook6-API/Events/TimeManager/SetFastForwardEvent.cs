namespace NKHook6.Api.Events._TimeManager
{
	public partial class TimeManagerEvents
	{
		public class SetFastForwardEvent
		{
			public class Pre : EventBaseCancellable
			{
				public bool value;

				public Pre(ref bool value) : base("TimeManager.SetFastForwardEvent.Pre")
				{
					this.value = value;
				}
			}

			public class Post : EventBase
			{
				public bool value;

				public Post(ref bool value) : base("TimeManager.SetFastForwardEvent.Post")
				{
					this.value = value;
				}
			}
		}
	}
}
