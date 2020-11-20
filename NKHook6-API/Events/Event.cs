using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKHook6.Api.Events
{
    public abstract class EventBase
    {
        public string eventName;
        public EventBase(string eventName)
        {
            this.eventName = eventName;
        }
    }
}
