using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKHook6.API.Events
{
    [EventInfo("EventBaseCancellable")]
    public class EventBaseCancellable : EventBase
    {
        public bool cancelled;
        public EventBaseCancellable() : base() { }
        public void SetCancelled(bool cancelled)
        {
            this.cancelled = cancelled;
        }
        public bool IsCancelled()
        {
            return this.cancelled;
        }
    }
}
