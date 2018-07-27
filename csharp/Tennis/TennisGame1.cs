namespace Tennis
{
    internal class TennisGame1 : ITennisGame
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
            var gameState = GameState.GetGameState(player1, player2);

            return gameState.GetScore();
        }
    }
}

