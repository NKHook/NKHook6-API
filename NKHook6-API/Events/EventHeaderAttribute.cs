using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKHook6.API.Events
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public class EventHeader : Attribute
    {
        public string eventName;
        public EventHeader(string eventName)
        {
            this.eventName = eventName;
        }
    }
}