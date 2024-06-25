namespace SOSCSRPG.Core
{
    public class GameMessageEventArgs(string message) : System.EventArgs
    {
        public string Message { get; private set; } = message;
    }
}
