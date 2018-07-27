using System.Collections.Generic;
using NUnit.Framework;

namespace Tennis
{
    internal class TennisGame1 : ITennisGame
    {
        private readonly Player player1;
        private readonly Player player2;
        private readonly List<IScoreHandler> scoreHandlers;

        public TennisGame1(string player1Name, string player2Name)
        {
            player1 = new Player(player1Name);
            player2 = new Player(player2Name);

            scoreHandlers = new List<IScoreHandler>()
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
            // TODO: move this somewhere else? Too many levels of indentation
            foreach (var scoreHandler in scoreHandlers)
            {
                if (scoreHandler.CanHandle(player1, player2))
                {
                    return scoreHandler.GetScore(player1, player2);
                }
            }

            throw new ScoreHandlerNotFoundException("Could not find a score handler for situation");
        }
    }
}

