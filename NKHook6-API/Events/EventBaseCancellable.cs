using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKHook6.API.Events
{
    public class EventBaseCancellable : EventBase
    {
        public bool cancelled;
        public EventBaseCancellable(string eventName) : base(eventName) { }
        public void SetCancelled(bool cancelled)
        {
            this.cancelled = cancelled;
        }
        public bool isCancelled()
        {
            return this.cancelled;
        }
    }
}
