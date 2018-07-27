namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private int m_score1 = 0;
        private int m_score2 = 0;
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
                m_score1 += 1;
            else
                m_score2 += 1;
        }

        public string GetScore()
        {
            if (ScoresAreEqual())
            {
                return GetEqualScoresDescription();
            }
            else if (ScoresAreInAdvantageAndWinRange())
            {
                return GetAdvantageAndWinScores();
            }
            else
            {
                var score = "";
                for (var i = 1; i < 3; i++)
                {
                    var tempScore = 0;
                    if (i == 1)
                    {
                        tempScore = m_score1;
                    }
                    else
                    {
                        score += "-"; tempScore = m_score2;
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

        }

        private string GetAdvantageAndWinScores()
        {
            var minusResult = m_score1 - m_score2;
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
            return m_score1 >= 4 || m_score2 >= 4;
        }

        private bool ScoresAreEqual()
        {
            return m_score1 == m_score2;
        }

        private string GetEqualScoresDescription()
        {
            switch (m_score1)
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

