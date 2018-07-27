namespace Tennis
{
    internal abstract class GameState
    {
        protected readonly Player player1;
        private readonly Player player2;

        public static GameState GetGameState(Player player1, Player player2)
        {
            if (player1.Score == player2.Score)
            {
                return new EqualScoreState(player1, player2);
            }

            return null;
        }

        protected GameState(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public abstract string GetScore();
    }

    internal class EqualScoreState : GameState
    {
        public override string GetScore()
        {
            switch (player1.Score)
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

        public EqualScoreState(Player player1, Player player2) : base(player1, player2)
        {
        }
    }
}
