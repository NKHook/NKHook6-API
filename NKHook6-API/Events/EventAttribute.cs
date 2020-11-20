using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKHook6.Api.Events
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    public class EventAttribute : Attribute
    {
        public string eventName;
        public EventAttribute(string eventName)
        {
            this.eventName = eventName;
        }
    }
}
