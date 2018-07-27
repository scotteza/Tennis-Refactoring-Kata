using System;

namespace Tennis.Exceptions
{
    public class ScoreHandlerNotFoundException : Exception
    {
        public ScoreHandlerNotFoundException(string message) : base(message)
        {
        }
    }
}
