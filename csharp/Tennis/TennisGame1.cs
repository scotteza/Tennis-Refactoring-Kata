namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private int player1Score = 0;
        private int player2Score = 0;
        private string player1Name;
        private string player2Name;

        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                player1Score += 1;
            else
                player2Score += 1;
        }

        public string GetScore()
        {
            var gameState = GameState.GetGameState(player1Score, player2Score);
            if (gameState != null)
            {
                return gameState.GetScore();
            }

            if (ScoresAreEqual())
            {
                return GetEqualScoresDescription();
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
                    tempScore = player1Score;
                }
                else
                {
                    score += "-";
                    tempScore = player2Score;
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
            var minusResult = player1Score - player2Score;
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
            return player1Score >= 4 || player2Score >= 4;
        }

        private bool ScoresAreEqual()
        {
            return player1Score == player2Score;
        }

        private string GetEqualScoresDescription()
        {
            switch (player1Score)
            {
                case 0:
                    return "Love-All";
                case 1:
                    return "Fifteen-All";
                case 2:
                    return "Thirty-All";
                default:
                    return "Deuce";
            }
        }
    }
}

