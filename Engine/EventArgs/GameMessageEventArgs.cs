using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.EventArgs
{
    public class GameMessageEventArgs(string message) : System.EventArgs
    {
        public string Message { get; private set; } = message;
    }
}
