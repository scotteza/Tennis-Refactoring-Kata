using System;

namespace Tennis
{
    public class ScoreHandlerNotFoundException : Exception
    {
        public ScoreHandlerNotFoundException(string message) : base(message)
        {
        }
    }
}
