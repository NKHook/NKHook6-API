﻿using NKHook6.API.Bloons;

namespace NKHook6.API.Events._Bloons
{
    public partial class BloonEvents
    {
        [EventHeader("BloonLeakedEvent")]
        public class LeakedEvent : EventBaseCancellable, BloonEvent
        {
            private IBloonEntity bloon;

            public LeakedEvent(IBloonEntity bloon) : base()
            {
                this.bloon = bloon;
            }

            public IBloonEntity GetBloon()
            {
                return this.bloon;
            }
        }
    }
}
