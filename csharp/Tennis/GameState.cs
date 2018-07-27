namespace Tennis
{
    internal abstract class GameState
    {
        protected readonly Player Player1;
        protected readonly Player Player2;

        public static GameState GetGameState(Player player1, Player player2)
        {
            if (player1.Score == player2.Score)
            {
                return new EqualScoreGameState(player1, player2);
            }

            if (player1.Score >= 4 || player2.Score >= 4)
            {
                return new InAdvantageAndWinRangeGameState(player1, player2);
            }

            return new NormalCaseGameState(player1, player2);
        }

        protected GameState(Player player1, Player player2)
        {
            this.Player1 = player1;
            this.Player2 = player2;
        }

        public abstract string GetScore();
    }
}
