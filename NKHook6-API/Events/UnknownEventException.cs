using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKHook6.API.Events
{
    public class UnknownEventException : Exception
    {
        public UnknownEventException(string unknownEvent) : base("Unknown event \""+ unknownEvent+"\"")
        {

        }
    }
}
