using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKHook6.Api
{
    public class CommandManager
    {
		public static event EventHandler<string> CommandEvent;

        public static void onCommand(string input)
        {
            EventHandler<string> onCommandHandler = CommandEvent;
            if (onCommandHandler != null)
                onCommandHandler.Invoke(null, input);
        }
    }
}
