using Tennis.Exceptions;

namespace Tennis.ScoreHandlers
{
    public class ScoreHandlerChain
    {
        private readonly IScoreHandler[] scoreHandlers;

        public ScoreHandlerChain()
        {
            scoreHandlers = new IScoreHandler[]
            {
                new EqualScoreHandler(),
                new WinningScoreHandler(),
                new AdvantageHandler(),
                new NormalCaseScoreHandler()
            };
        }

        public string GetScoreDescription(Scores scores)
        {
            // TODO: Too many levels of indentation? Is this really a problem here?
            foreach (var scoreHandler in scoreHandlers)
            {
                if (scoreHandler.CanHandle(scores))
                {
                    return scoreHandler.GetScoreDescription(scores);
                }
            }

            throw new ScoreHandlerNotFoundException("Could not find a score handler for situation");
        }
    }
}
