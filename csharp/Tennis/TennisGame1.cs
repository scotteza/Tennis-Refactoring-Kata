using Tennis.Exceptions;
using Tennis.ScoreHandlers;

namespace Tennis
{
    internal class TennisGame1 : ITennisGame
    {
        private readonly Player player1;
        private readonly Player player2;
        private readonly ScoreHandlerChain scoreHandlerChain;

        public TennisGame1(string player1Name, string player2Name)
        {
            player1 = new Player(player1Name);
            player2 = new Player(player2Name);

            scoreHandlerChain = new ScoreHandlerChain();
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
            return scoreHandlerChain.GetScoreDescription(scores);
        }

        private Scores GetGameScores()
        {
            return new Scores(player1.Score, player2.Score);
        }
    }
}

