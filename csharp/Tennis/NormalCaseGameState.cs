namespace Tennis
{
    internal class NormalCaseGameState : GameState
    {
        public NormalCaseGameState(Player player1, Player player2) : base(player1, player2)
        {
        }

        public override string GetScore()
        {
            var score = "";
            for (var i = 1; i < 3; i++)
            {
                var tempScore = 0;
                if (i == 1)
                {
                    tempScore = Player1.Score;
                }
                else
                {
                    score += "-";
                    tempScore = Player2.Score;
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
}