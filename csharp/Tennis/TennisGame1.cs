using Tennis.Exceptions;
using Tennis.ScoreHandlers;

namespace Tennis
{
    internal class TennisGame1 : ITennisGame
    {
        private readonly Player player1;
        private readonly Player player2;

        // TODO: move this somewhere else?
        private readonly IScoreHandler[] scoreHandlers;

        public TennisGame1(string player1Name, string player2Name)
        {
            player1 = new Player(player1Name);
            player2 = new Player(player2Name);

            scoreHandlers = new IScoreHandler[]
            {
                new EqualScoreHandler(),
                new InAdvantageAndWinRangeScoreHandler(),
                new NormalCaseScoreHandler()
            };
        }

        public void WonPoint(string playerName)
        {
            if (playerName == player1.Name)
            {
                player1.WonPoint();
            }
            else
            {
                player2.WonPoint();
            }
        }

        public string GetScore()
        {
            var scores = GetGameScores();

            // TODO: move this somewhere else? Too many levels of indentation
            foreach (var scoreHandler in scoreHandlers)
            {
                if (scoreHandler.CanHandle(scores))
                {
                    return scoreHandler.GetScoreDescription(scores);
                }
            }

            throw new ScoreHandlerNotFoundException("Could not find a score handler for situation");
        }

        private Scores GetGameScores()
        {
            return new Scores(player1.Score, player2.Score);
        }
    }
}

