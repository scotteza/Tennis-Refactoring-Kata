namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private readonly Player player1;
        private readonly Player player2;

        public TennisGame1(string player1Name, string player2Name)
        {
            player1 = new Player(player1Name);
            player2 = new Player(player2Name);
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
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
            var gameState = GameState.GetGameState(player1.Score, player2.Score);
            if (gameState != null)
            {
                return gameState.GetScore();
            }

            if (ScoresAreInAdvantageAndWinRange())
            {
                return GetAdvantageAndWinScores();
            }

            return GetScoreForNormalCases();
        }

        private string GetScoreForNormalCases()
        {
            var score = "";
            for (var i = 1; i < 3; i++)
            {
                var tempScore = 0;
                if (i == 1)
                {
                    tempScore = player1.Score;
                }
                else
                {
                    score += "-";
                    tempScore = player2.Score;
                }

                switch (tempScore)
                {
                    case 0:
                        score += "Love";
                        break;
                    case 1:
                        score += "Fifteen";
                        break;
                    case 2:
                        score += "Thirty";
                        break;
                    case 3:
                        score += "Forty";
                        break;
                }
            }

            return score;
        }

        private string GetAdvantageAndWinScores()
        {
            var minusResult = player1.Score - player2.Score;
            if (minusResult == 1)
            {
                return "Advantage player1";
            }
            else if (minusResult == -1)
            {
                return "Advantage player2";
            }
            else if (minusResult >= 2)
            {
                return "Win for player1";
            }
            else
            {
                return "Win for player2";
            }
        }

        private bool ScoresAreInAdvantageAndWinRange()
        {
            return player1.Score >= 4 || player2.Score >= 4;
        }
    }
}

