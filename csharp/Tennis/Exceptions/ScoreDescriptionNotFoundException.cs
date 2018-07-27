using System;

namespace Tennis.Exceptions
{
    public class ScoreDescriptionNotFoundException : Exception
    {
        public ScoreDescriptionNotFoundException(string message) : base(message)
        {
        }
    }
}
